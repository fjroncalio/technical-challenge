using Microsoft.Extensions.Logging;
using Polly;
using Polly.Retry;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechnicalChallenge.Domain.Core
{
    public abstract class RetryPollicy<T>
    {
        protected readonly ILogger<T> _logger;

        protected RetryPollicy(ILogger<T> logger)
        {
            _logger = logger;
        }

        protected async Task<TResponse> HandleAsync<TResponse>(Func<Task<TResponse>> operation)
        {
            return await GetRetryPolicy().ExecuteAsync(operation);
        }

        private AsyncRetryPolicy GetRetryPolicy()
        {
            return Policy
                    .Handle<TimeoutException>()
                    .Or<AggregateException>()
                    .Or<TaskCanceledException>()
                    .WaitAndRetryAsync(
                        sleepDurations: new List<TimeSpan>{
                            TimeSpan.FromSeconds(1),
                            TimeSpan.FromSeconds(2),
                            TimeSpan.FromSeconds(3)
                        },
                        onRetry: (exception, duration, attempt, context) =>
                        {
                            _logger.LogInformation(
                                exception,
                                $"{nameof(T)} => Any problem in {attempt} attempt. Process in {duration.TotalMilliseconds}ms.");
                        });
        }
    }
}