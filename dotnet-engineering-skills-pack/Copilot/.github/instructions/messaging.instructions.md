---
applyTo: "**/*Consumer*.cs,**/*Producer*.cs,**/*Handler*.cs"
---

# Messaging Guidelines - Enterprise Systems

Considerar arquitetura orientada a eventos utilizando mensageria.

Exemplos:

- Azure Service Bus.
- RabbitMQ.
- Kafka.

---

## Eventos

Diferenciar:

### Domain Events

Eventos internos do domínio.

### Integration Events

Eventos publicados entre serviços.

---

## Contratos

Eventos devem possuir:

- Nome claro.
- Versão.
- Schema definido.
- Payload estável.
- Compatibilidade futura.

---

## Consumers

Devem ser:

- Idempotentes.
- Resilientes.
- Observáveis.

Considerar:

- Mensagens duplicadas.
- Falhas temporárias.
- Retry.
- Dead Letter Queue.

---

## Retry

Implementar:

- Retry para erros transitórios.
- Backoff progressivo.
- Limite de tentativas.

Após limite:

- Encaminhar para DLQ.
- Registrar contexto da falha.

---

## Producer

Antes de publicar eventos:

Garantir:

- Dados consistentes.
- Contrato válido.
- Versionamento adequado.

---

## Observabilidade

Registrar:

- MessageId.
- CorrelationId.
- Causas de falha.
- Tempo de processamento.

Utilizar:

- Logs estruturados.
- Distributed Tracing.
- OpenTelemetry.