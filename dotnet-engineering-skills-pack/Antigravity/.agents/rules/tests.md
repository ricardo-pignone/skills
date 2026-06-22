---
applyTo: "**/*Tests.cs"
---

# Testing Guidelines - .NET Enterprise

Criar testes focados em comportamento e regras de negócio.

Não criar testes apenas para aumentar cobertura.

---

## Estratégia

Priorizar:

1. Testes unitários.
2. Testes de integração.
3. Testes de contrato.
4. Testes end-to-end para fluxos críticos.

---

## Frameworks preferenciais

Considerar:

- xUnit.
- FluentAssertions.
- Moq ou NSubstitute.
- Testcontainers.
- WebApplicationFactory.

---

## Testes unitários

Devem validar:

- Regras de negócio.
- Casos de uso.
- Validações.
- Cenários de erro.

Evitar:

- Testar implementação interna.
- Testar getters/setters simples.
- Excessos de mocks.

---

## Padrão de teste

Preferir:

Arrange
Act
Assert


Exemplo:

- Preparar contexto.
- Executar comportamento.
- Validar resultado.

---

## Testes de integração

Utilizar quando envolver:

- Banco de dados.
- Mensageria.
- APIs externas.
- Persistência.

Validar comportamento real da integração.

---

## Qualidade

Cada teste deve responder:

- Qual comportamento está protegido?
- Qual risco evita?
- Qual regra valida?