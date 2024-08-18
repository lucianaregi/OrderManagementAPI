# OrderManagementAPI

OrderManagementAPI é uma aplicação ASP.NET Core Web API para gerenciar pedidos, demonstrando o uso da Arquitetura em Camadas e a aplicação dos princípios SOLID. Esta aplicação permite a criação de pedidos, o processamento de pagamentos e o envio de notificações aos clientes.

## Estrutura do Projeto

O projeto é dividido em quatro camadas principais:

1. **Presentation Layer (OrderManagementAPI)**
   - Responsável por expor as APIs para interação com o sistema.
   - Contém os controladores da aplicação.

2. **Application Layer (OrderManagement.Application)**
   - Contém a lógica de orquestração do fluxo de trabalho.
   - Inclui serviços que coordenam as operações das entidades de domínio.

3. **Domain Layer (OrderManagement.Domain)**
   - Contém as entidades de domínio e as interfaces que representam as regras de negócio.
   - Inclui as abstrações para os processadores de pagamento e serviços de notificação.

4. **Infrastructure Layer (OrderManagement.Infrastructure)**
   - Implementa os detalhes de infraestrutura, como processadores de pagamento e serviços de notificação específicos.

## Pré-requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [Git](https://git-scm.com/)

## Configuração e Execução

Siga os passos abaixo para configurar e executar a aplicação localmente:

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/seu-usuario/order-management-api.git
   cd order-management-api
