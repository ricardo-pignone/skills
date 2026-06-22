---
applyTo: "**/*Tests.cs"
---

Para testes:

- Utilizar xUnit.
- Usar FluentAssertions.
- Priorizar testes de comportamento.---
applyTo: "**/*.{cs,csproj,sln}"
---

# Architecture Guidelines - .NET Enterprise

Atue considerando uma arquitetura enterprise baseada em:

- Clean Architecture
- Domain Driven Design
- SOLID
- CQRS
- Event Driven Architecture
- Microsserviços

## Princípios

Sempre priorizar:

- Alta coesão.
- Baixo acoplamento.
- Separação clara de responsabilidades.
- Independência do domínio.
- Evolução sustentável.

## Camadas esperadas

Considerar a separação:

API
↓
Application
↓
Domain
↓
Infrastructure


## Domain Layer

O domínio deve:

- Conter regras de negócio.
- Ser independente de frameworks.
- Evitar dependências externas.
- Utilizar Entities, Value Objects e Domain Services quando necessário.

Evitar:

- Domínio anêmico.
- Regras espalhadas.
- Lógica de negócio em Controllers ou Infrastructure.


## Application Layer

Responsável por:

- Casos de uso.
- Orquestração.
- Commands.
- Queries.
- Validações de entrada.
- Coordenação de dependências.

Evitar:

- Regras complexas de negócio.
- Acesso direto a infraestrutura.


## Infrastructure Layer

Responsável por:

- Banco de dados.
- Mensageria.
- APIs externas.
- Serviços de terceiros.

Manter:

- Implementações isoladas.
- Interfaces no nível apropriado.


## Revisão arquitetural

Ao sugerir alterações:

- Avaliar impacto.
- Considerar trade-offs.
- Evitar complexidade desnecessária.
- Justificar decisões arquiteturais.
- Evitar testar implementação interna.