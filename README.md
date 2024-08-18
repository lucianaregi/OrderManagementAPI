# OrderManagementAPI

OrderManagementAPI � uma aplica��o ASP.NET Core Web API para gerenciar pedidos, demonstrando o uso da Arquitetura em Camadas e a aplica��o dos princ�pios SOLID. Esta aplica��o permite a cria��o de pedidos, o processamento de pagamentos e o envio de notifica��es aos clientes.

## Estrutura do Projeto

O projeto � dividido em quatro camadas principais:

1. **Presentation Layer (OrderManagementAPI)**
   - Respons�vel por expor as APIs para intera��o com o sistema.
   - Cont�m os controladores da aplica��o.

2. **Application Layer (OrderManagement.Application)**
   - Cont�m a l�gica de orquestra��o do fluxo de trabalho.
   - Inclui servi�os que coordenam as opera��es das entidades de dom�nio.

3. **Domain Layer (OrderManagement.Domain)**
   - Cont�m as entidades de dom�nio e as interfaces que representam as regras de neg�cio.
   - Inclui as abstra��es para os processadores de pagamento e servi�os de notifica��o.

4. **Infrastructure Layer (OrderManagement.Infrastructure)**
   - Implementa os detalhes de infraestrutura, como processadores de pagamento e servi�os de notifica��o espec�ficos.

## Pr�-requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [Git](https://git-scm.com/)

## Configura��o e Execu��o

Siga os passos abaixo para configurar e executar a aplica��o localmente:

1. **Clone o reposit�rio:**

   ```bash
   git clone https://github.com/seu-usuario/order-management-api.git
   cd order-management-api
