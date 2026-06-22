---
applyTo: "**/{Controllers,Endpoints,Api,API}/**/*.cs"
---

# API Guidelines - ASP.NET Core Enterprise

Criar APIs seguindo boas práticas REST.

---

## Controllers / Endpoints

Responsabilidade:

- Receber requisição.
- Validar entrada.
- Delegar para Application Layer.
- Retornar resposta.

Evitar:

- Regras de negócio.
- Acesso direto ao banco.
- Processamento complexo.

---

## Contratos

Utilizar:

- DTOs.
- Request Models.
- Response Models.

Evitar expor:

- Entidades de domínio.
- Modelos internos.

---

## HTTP

Utilizar corretamente:

- GET.
- POST.
- PUT.
- PATCH.
- DELETE.

Retornar:

- Status HTTP adequado.
- Mensagens consistentes.
- ProblemDetails para erros.

---

## Segurança

Considerar:

- Autenticação.
- Autorização.
- Claims.
- Políticas.
- Validação de entrada.

---

## Observabilidade

APIs devem possuir:

- Logs estruturados.
- Correlation ID.
- Métricas.
- Tracing distribuído.

---

## Versionamento

Considerar:

- Versionamento de API.
- Compatibilidade retroativa.
- Evolução de contratos.