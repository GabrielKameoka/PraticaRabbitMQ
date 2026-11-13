# RabbitMQ Lab

Uma Web API .NET mínima e um guia interativo para aprender RabbitMQ por etapas.

## Começar

Requisitos: .NET 10 SDK e Docker Desktop.

```powershell
docker compose up -d
dotnet run
```

Abra <http://localhost:5267>. O painel RabbitMQ local fica em <http://localhost:15672> (usuário e senha `practice`).

## API de partida

- `POST /api/users` e `GET /api/users`
- `POST /api/products` e `GET /api/products`

Os dados ficam em memória e somem ao reiniciar a API. Não há banco nem camada de services. A API começa sem dependência RabbitMQ; o guia mostra como adicioná-la gradualmente.

O progresso da trilha, respostas e anotações são salvos no `localStorage` deste navegador.

## Referências oficiais

- [Guia da API RabbitMQ .NET](https://www.rabbitmq.com/client-libraries/dotnet-api-guide)
- [Tutorial .NET: Work Queues e acknowledgements](https://www.rabbitmq.com/tutorials/tutorial-two-dotnet)
- [Tutorial .NET: Routing](https://www.rabbitmq.com/tutorials/tutorial-four-dotnet)
