📱 Cadastro de Usuários - MAUI App


Este repositório contém o código fonte de um aplicativo de cadastro de usuários desenvolvido em C# utilizando o .NET MAUI. O app é compatível com Android e iOS e utiliza um banco de dados local SQLite para armazenar as contas de usuário.


🚀 Funcionalidades


✏️ Cadastro de Usuário: Permite o cadastro de usuários com e-mail e senha, com validações de dados.

🔐 Login: Usuários podem fazer login utilizando suas credenciais.

📝 Editar Conta: Após o login, o usuário pode editar as suas informações.

👥 Visualizar Usuários: O app permite visualizar a lista de outros usuários cadastrados.

✅ Validações: O app faz validação dos campos de entrada e verifica as credenciais durante o login.


🛠️ Tecnologias Utilizadas


C#: Linguagem de programação.

.NET MAUI: Framework multi-plataforma para aplicativos móveis.

SQLite: Banco de dados local para armazenamento de informações de usuários.

XAML: Usado para criar as interfaces gráficas do aplicativo.


📂 Estrutura do Projeto


O projeto segue uma estrutura organizada em diferentes pastas, separadas conforme o padrão Repository, Service, Model e View, visando manter uma arquitetura clara e escalável:


Model: Contém os modelos de dados que representam as entidades do sistema, como o usuário. Esses modelos são responsáveis por estruturar as informações que serão armazenadas no banco de dados.


View: Inclui as páginas de interface do usuário, implementadas em XAML. Essas páginas são responsáveis pela apresentação e interação com o usuário, como as telas de login, cadastro e lista de usuários.

Repositories: Implementa a lógica de acesso ao banco de dados, especificamente as operações CRUD (Create, Read, Update, Delete). Essa camada abstrai os detalhes da comunicação com o banco, mantendo o código mais organizado e testável.

Services: Contém as regras de negócio e gerencia a comunicação entre os Repositories e as Views. Além disso, os serviços realizam validações e outras operações lógicas relacionadas ao processamento de dados do usuário.


📱 Como utilizar

Para executar o app é necessário a instalação dos pacotes SQLiteNetPCL, SQliteRaw Bundle no ambiente .NET juntamente com o MAUI. Após isso o app estará pronto para ser compilado e executado.
