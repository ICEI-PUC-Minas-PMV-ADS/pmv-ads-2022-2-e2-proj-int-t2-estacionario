# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
* Site publicado na Internet
* Navegador da Internet - Chrome, Firefox ou Edge
* Conectividade de Internet para acesso às plataformas (APISs)
* Utilizar o leitor de telas NVDA atualizado.

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

| Caso de Teste | CT-01 - Encontrar um estacionamento por meio do campo de busca |
| :------------: | ------------------------------------------------------------------------------- |
| Requisitos associados | RF-001 - A aplicação deve apresentar a funcionalidade de buscador<br> RF-003 - A aplicação deve apresentar as informações do estabelecimento e serviços extras oferecidos<br> RF-006 - A aplicação deve possuir um filtro para refinar a busca do usuário | 
| Objetivos do teste | Validar se o campo de busca trás estabelecimentos de forma precisa. |
| Passos | 1. abrir o navegador<br> 2. acessar o endereço: https://www.xxxx.xx.xx<br> 3. Navegar até o campo de busca e inserir um nome de estacionamento<br> 4. pressionar o botão buscar |
| Critério de êxito | Após pressionar o botão buscar a aplicação deve exibir estacionamentos relacionados ao termo buscado no input. |

| Caso de Teste | CT-02 - Usuário faz busca de estacionamento por meio dos filtros |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-002 - A aplicação deve apresentar categorias de vagas para facilitar a busca dos usuários<br> RF-006 - A aplicação deve possuir um filtro para refinar a busca do usuário|
| Objetivos do teste | Validar se os filtros estejam direcionando para os resultados selecionados |
| Passos | 1. abrir o navegador;<br> 2. acessar o endereço: https://www.xxxx.xx.xx;<br> 3. navegar até a sessão dos filtros de estacionamentos;<br> 4. selecionar o tipo de vaga, estado, cidade e bairro. |
| Critério de êxito| Após selecionar todos os filtros deverá aparecer estacionamentos com as características filtradas. |

| Caso de Teste | CT-03 - Usuário comum realiza cadastro |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-009 - A aplicação deve possuir uma área para cadastrar novos usuários e empresas |
| Objetivos do teste | Validar se à aplicação está permitindo a criação de novos usuários com os dados obrigatórios solicitados. |
| Passos | 1. abrir o navegador;<br> 2. acessar o endereço: https://www.xxxx.xx.xx;<br> 3. Navegar até o link "Cadastrar" e pressioná-lo. <br> 4. Escolher a opção usuário comum;<br> 5. preencher todos os campos obrigatórios solicitado;<br> 6. pressionar o botão cadastrar.|
| Critério de êxito | Após o correto preenchimento do formulário e pressionar o botão cadastrar, o usuário deve conseguir fazer login com as credenciais cadastradas e ter acesso as funcionalidades da aplicação que exige login. |

| Caso de Teste | CT-04 - Usuário comum faz login |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-007 - A aplicação deve possuir uma área de login para que o usuário possa fazer reservas de vagas<br> RF-013 - A aplicação deve ter dentro da área de login de usuários uma sessão de locais favoritados
| Objetivos do teste | Validar à área de login e se um usuário previamente cadastrado consegue logar-se. |
| Passos |1. abrir o navegador;<br> 2. acessar o endereço: https://www.xxxx.xx.xx;<br> 3. Navegar até o link "login" e pressioná-lo.<br> 4. inserir e-mail e senha válida;<br> 5. pressionar o botão "acessar". |
| Critério de êxito | Após o preenchimento correto do e-mail e senha válidos e pressionar o botão "acessar" o usuário deve ser direcionado para sua área logada. |
