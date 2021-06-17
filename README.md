# Technical Challenge

Esse repositório possui a implementação de um desafio técnico onde um número deve ser decomposto por todos seus divisores e dentre seus divisores saber quais são números primos

## Tecnologias

- MediatR <i>(Utilizado em conjunto com o padrão CQRS para disparo de comandos)</i>
- Polly <i>(Utilizado para fazer tratamento de falhas, para que o fluxo seja resiliente)</i>
- XUnit <i>(Utilizado para realizar os testes de unidade sobre o dominio)</i>
- NSubstitue <i>(Utilizado para realizar os moqs necessários para os testes de unidade)</i>
- FluentAssertions <i>(Utilizado para realizar testes de unidade de uma forma mais humana)</i>

## Execução dos testes de unidade

Abra o powershell no diretório src do projeto e execute os comandos:

1 - dotnet test

## Execução no ambiente docker

Abra o powershell no diretório src do projeto e execute os seguintes comandos:

1 - docker build -t {nome desejado para imagem}:{versao da imagem} .

- Ex: docker build -t technicalchallenge:v1 .
	
2 - docker run {nome dado para imagem}:{versao da imagem}

- Ex: docker run technicalchallenge:v1