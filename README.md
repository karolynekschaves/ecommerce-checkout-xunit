# Ecommerce Checkout

Projeto de estudo em C#/.NET que reúne regras simples de checkout e testes unitários com xUnit.

## Funcionalidades

O serviço `PerfilJogadorService`, localizado no projeto `EcommerceCheckout.App`, oferece:

- **Código de rastreio:** converte a região para maiúsculas e formata o número do pedido com quatro dígitos. Exemplo: `sudeste` e `42` geram `SUDESTE-0042`.
- **Pontos de fidelidade:** concede 2 pontos por cada R$ 10 inteiros do valor total. Exemplo: R$ 150 geram 30 pontos.
- **Frete grátis:** disponível para pedidos de pelo menos R$ 200 ou para clientes VIP.

## Tecnologias

- C# e .NET 10
- xUnit 2.9 para testes unitários
- `Microsoft.NET.Test.Sdk` para execução dos testes

## Pré-requisitos

- .NET SDK 10.0 instalado

## Como executar

No terminal, a partir da raiz do repositório:

```bash
cd EcommerceCheckout
dotnet restore
dotnet run --project EcommerceCheckout.App
```

Atualmente, o programa de console exibe `Hello, World!`. As regras de checkout estão implementadas no serviço e cobertas pelos testes; ainda não há um fluxo interativo de compra.

## Como testar

Na pasta `EcommerceCheckout`, execute:

```bash
dotnet test
```

Os testes verificam a formatação do código de rastreio, o cálculo de pontos e as condições de frete grátis para clientes VIP e não VIP.

## Estrutura

```text
EcommerceCheckout/
├── EcommerceCheckout.App/       # Aplicação e regras do serviço
├── EcommerceCheckout.Tests/     # Testes unitários xUnit
└── EcommerceCheckout.slnx       # Solução .NET
```

## Licença

Distribuído sob a licença MIT. Consulte [LICENSE](LICENSE).