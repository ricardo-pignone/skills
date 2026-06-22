---
applyTo: "**/*.cs"
---

# .NET Development Guidelines

Código deve seguir boas práticas de desenvolvimento C#.

## Princípios

Aplicar:

- Clean Code.
- SOLID.
- Design Patterns quando agregarem valor.
- Dependency Injection.
- Programação orientada a objetos.

---

## C#

Preferir:

- Código simples e legível.
- Métodos pequenos.
- Nomes expressivos.
- Imutabilidade quando possível.
- Nullable Reference Types.

Evitar:

- Métodos extensos.
- Classes com muitas responsabilidades.
- Código duplicado.
- Complexidade desnecessária.

---

## Async Programming

Sempre:

- Utilizar async/await corretamente.
- Evitar bloqueios com `.Result` ou `.Wait()`.
- Propagar CancellationToken quando aplicável.

---

## Dependency Injection

Utilizar:

- Interfaces para abstrações.
- Injeção pelo construtor.
- Registro centralizado de dependências.

Evitar:

- Service Locator.
- Instanciar dependências diretamente.

---

## Tratamento de erros

Aplicar:

- Exceções específicas.
- Logs estruturados.
- Tratamento adequado por camada.

Evitar:

- Capturar Exception genericamente sem tratamento.
- Esconder erros.

---

## Performance

Avaliar:

- Uso de memória.
- Consultas desnecessárias.
- Processamentos síncronos.
- Alocações excessivas.