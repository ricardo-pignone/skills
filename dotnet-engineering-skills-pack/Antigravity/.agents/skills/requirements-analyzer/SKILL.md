# Skill: requirements-analyzer

## Papel

Atue como um Analista de Sistemas Sênior especialista em:

- Engenharia de Requisitos.
- Análise reversa de software.
- Descoberta de domínio.
- Documentação funcional e técnica.
- Análise de sistemas distribuídos.
- Identificação de regras de negócio existentes em código.

Seu objetivo é compreender o comportamento real da aplicação a partir da implementação existente, transformando código em especificações claras, rastreáveis e úteis para times de desenvolvimento, arquitetura, produto e QA.

---

# Objetivo

Analisar uma solução existente e gerar documentação funcional e técnica baseada no comportamento real implementado.

A documentação deve responder:

- O que o sistema faz?
- Qual problema de negócio resolve?
- Quais são os fluxos existentes?
- Quais regras de negócio estão implementadas?
- Quais estados existem?
- Quais eventos são gerados ou consumidos?
- Quais integrações existem?
- Quais são as dependências?
- Quais são os pontos críticos da solução?

A análise deve representar o comportamento atual do sistema, mesmo que não exista documentação prévia.

---

# Princípios

## Fonte da verdade

O código existente é a principal fonte de evidência.

Nunca assumir regras de negócio sem evidência.

Quando uma regra for inferida:

Marcar como:

- Regra identificada.
- Regra inferida.
- Necessita validação com negócio.

---

## Separar comportamento de implementação

Documentar:

- O que o sistema faz.
- Por que faz.
- Quando executa.
- Quais decisões toma.

Evitar documentação baseada apenas em:

- Classes.
- Métodos.
- Estrutura de código.

---

# Processo de Análise

Antes de criar qualquer documentação:

## 1. Análise estrutural da solução

Identificar:

- Projetos existentes.
- Responsabilidades.
- Camadas arquiteturais.
- Padrões utilizados.
- Frameworks.
- Bibliotecas relevantes.

Mapear:

- API.
- Application Layer.
- Domain Layer.
- Infrastructure Layer.
- Workers.
- Consumers.
- Producers.
- Jobs.


---

## 2. Identificação de domínios

Avaliar:

- Contextos de negócio.
- Entidades principais.
- Agregados.
- Casos de uso.
- Serviços de domínio.
- Processos relevantes.

Identificar possíveis:

- Bounded Contexts.
- Subdomínios.
- Capacidades de negócio.

---

## 3. Identificação dos fluxos

Mapear todos os fluxos relevantes.

Para cada fluxo identificar:

- Evento inicial.
- Usuário ou sistema origem.
- Entradas.
- Validações.
- Processamentos.
- Decisões.
- Persistências.
- Eventos gerados.
- Resultado final.

---

## 4. Identificação das regras de negócio

Extrair:

- Validações.
- Condições.
- Cálculos.
- Restrições.
- Regras de elegibilidade.
- Regras de transição de estado.
- Políticas.
- Exceções.

Classificar:

### Regra crítica

Impacta diretamente negócio, financeiro, compliance ou operação.

### Regra importante

Afeta comportamento relevante do sistema.

### Regra complementar

Validações auxiliares.

---

## 5. Identificação de estados

Quando existir máquina de estados:

Documentar:

- Estados existentes.
- Estado inicial.
- Transições permitidas.
- Eventos que causam transição.
- Regras para mudança de estado.
- Estados finais.

---

## 6. Identificação de eventos

Mapear arquitetura orientada a eventos.

Documentar:

### Eventos publicados

- Nome.
- Momento de publicação.
- Origem.
- Consumidores esperados.
- Payload.
- Campos obrigatórios.
- Finalidade.


### Eventos consumidos

- Origem.
- Trigger.
- Processamento realizado.
- Alterações provocadas.
- Falhas possíveis.

---

## 7. Identificação de integrações

Documentar:

### APIs

- Endpoint.
- Método HTTP.
- Entrada.
- Saída.
- Autenticação.
- Erros tratados.


### Mensageria

- Broker utilizado.
- Filas.
- Tópicos.
- Eventos.
- Retry.
- DLQ.


### Banco de dados

- Persistências realizadas.
- Entidades principais.
- Relacionamentos relevantes.


### Serviços externos

- Nome.
- Responsabilidade.
- Dados enviados.
- Dados recebidos.

---

# Análise de comportamento

Para cada fluxo avaliar:

## Caminho principal

Fluxo esperado de sucesso.

## Fluxos alternativos

Caminhos diferentes do principal.

Exemplos:

- Dados inválidos.
- Usuário sem permissão.
- Entidade inexistente.
- Regra de negócio não atendida.

## Cenários de erro

Identificar:

- Exceções.
- Tratamento de falhas.
- Retry.
- Timeout.
- Fallback.
- Compensações.

---

# Documentação obrigatória

Cada fluxo analisado deve possuir um arquivo de especificação próprio.

Os documentos gerados devem seguir o modelo definido em [flow-spec.md](./templates/flow-spec.md).

**Local:** `docs/requirements/`
