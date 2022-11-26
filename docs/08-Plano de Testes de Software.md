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
| Passos | 1. abrir o navegador;<br> 2. acessar o endereço: https://www.xxxx.xx.xx;<br> 3. Navegar até o link "Criar Conta" e pressioná-lo. <br> 4. Escolher a opção usuário comum;<br> 5. preencher todos os campos obrigatórios solicitado;<br> 6. pressionar o botão "Criar Conta".|
| Critério de êxito | Após o correto preenchimento do formulário e pressionar o botão cadastrar, o usuário deve conseguir fazer login com as credenciais cadastradas e ter acesso as funcionalidades da aplicação que exige login. |

| Caso de Teste | CT-04 - Usuário comum faz login |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-007 - A aplicação deve possuir uma área de login para que o usuário possa fazer reservas de vagas<br> RF-013 - A aplicação deve ter dentro da área de login de usuários uma sessão de locais favoritados
| Objetivos do teste | Validar à área de login e se um usuário previamente cadastrado consegue logar-se. |
| Passos |1. abrir o navegador;<br> 2. acessar o endereço: https://www.xxxx.xx.xx;<br> 3. Navegar até o botão "Entrar" e pressioná-lo. Ou pelo botão "Login" no Menu<br> 4. inserir e-mail e senha válida;<br> 5. pressionar o botão "Entrar". |
| Critério de êxito | Após o preenchimento correto do e-mail e senha válidos e pressionar o botão "Entrar" o usuário deve ser direcionado para sua área logada. |

| Caso de Teste | CT-05 - Dono de Estacionamento realiza cadastro |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-009 - A aplicação deve possuir uma área para cadastrar novos usuários e empresas |
| Objetivos do teste | Validar se a aplicação está permitindo o cadastro de pessoas proprietárias de estacionamento |
| Passos | 1. abrir o navegador;<br> 2. acessar o endereço: https://www.xxxx.xx.xx;<br> 3. Navegar até o botão "Criar Conta" e pressioná-lo. <br> 4. Escolher a opção Dono de Estacionamentos;<br> 5. preencher todos os campos obrigatórios solicitado;<br> 6. pressionar o botão "Criar Conta".|
| Critério de êxito | Após o correto preenchimento do formulário e pressionar o botão cadastrar, o usuário deve conseguir fazer login com as credenciais cadastradas e ter acesso as funcionalidades da aplicação que exige login.<br> Se houverem campos não preenchidos o botão de cadastro deve estar desabilitado.<br> |

| Caso de Teste | CT-06 - Dono de Estacionamento realiza login |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-008 - A aplicação deve possuir uma área de login para as empresas fazer a gestão de suas reservas<br> RF-011	A aplicação deve possuir dentro da área de login da empresa um resumo de feedback dos usuários.
| Objetivos do teste | Validar à área de login e se um dono de estacionamento previamente cadastrado consegue logar-se. |
| Passos |1. abrir o navegador;<br> 2. acessar o endereço: https://www.xxxx.xx.xx;<br> 3. Navegar até o botão "Entrar" e pressioná-lo. Ou pelo botão "Login" no Menu <br> 4. inserir e-mail e senha válida;<br> 5. pressionar o botão "Entrar". |
| Critério de êxito | Após o preenchimento correto do e-mail e senha válidos e pressionar o botão "acessar" a pessoa proprietária de estacionamento deve ser direcionada para sua área logada. |

| Caso de Teste | CT-07 Dono de Estacionamento cadastra um estacionamento |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-008 - A aplicação deve possuir uma área de login para as empresas fazer a gestão de suas reservas
| Objetivos do teste | Validar se um dono de estacionamento consegue cadastrar um novo estabelecimento |
| Passos |1. abrir o navegador;<br> 2. fazer o login como dono de estacionamento( referir-se à CT-06);<br> 3. No menu clicar no botão "Cadastrar Estacionamento" <br> 4. Fazer o preenchimento do formulário <br> 5. Clicar no botão "Cadastrar Estacionamento"! |
| Critério de êxito | Após o preenchimento correto do formulário e o clique no botão, espera-se que o estacionamento seja registrado com sucesso, passando a aparecer na listagem dos usuários e na tela de gerenciamento de estacionamentos. <br> Quando o formulário for preenchido com números absurdos na quantidade de vagas, espera-se que o estacionamento não seja criado, ocorrendo um alerta para o preenchimento errôneo. <br> Não deve ser possível clicar no botão de cadastrar estacionamento sem o preenchimento completo do formulário. |

| Caso de Teste | CT-08 Dono de Estacionamento remove um estacionamento |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-008 - A aplicação deve possuir uma área de login para as empresas fazer a gestão de suas reservas
| Objetivos do teste | Validar se um dono de estacionamento consegue remover um estabelecimento |
| Passos |1. abrir o navegador;<br> 2. fazer o login como dono de estacionamento( referir-se à CT-06);<br> 3. No menu clicar no botão "Gerenciar estacionamentos cadastrados" <br> 4. Clicar no botão "Remover estacionamento" de um estacionamento <br> |
| Critério de êxito | Após o clique no botão, espera-se que o estacionamento não seja mais listado para usuários comuns ou na lista de estacionamentos cadastrados do dono de estacionamento. |

| Caso de Teste | CT-09  Dono de Estacionamento atualiza um estacionamento |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-008 - A aplicação deve possuir uma área de login para as empresas fazer a gestão de suas reservas
| Objetivos do teste | Validar se um dono de estacionamento consegue atualizar estabelecimento |
| Passos |1. abrir o navegador;<br> 2. fazer o login como dono de estacionamento( referir-se à CT-06);<br> 3. No menu clicar no botão "Gerenciar estacionamentos cadastrados" <br> 4. Clicar no botão "Atualizar estacionamento" de um estacionamento <br> 5. Fazer o alterações no formulário <br> 6. Clicar no botão "Salvar alterações" |
| Critério de êxito | Após o preenchimento correto do formulário e o clique no botão, espera-se que o estacionamento seja atualizado com sucesso, passando a aparecer na listagem dos usuários e na tela de gerenciamento de estacionamentos com as novas informações. <br> Quando o formulário for preenchido com números absurdos na quantidade de vagas, espera-se que o estacionamento não seja atualizado, ocorrendo um alerta para o preenchimento errôneo. <br> Não deve ser possível clicar no botão de salvar alterações sem o preenchimento completo do formulário. |

| Caso de Teste | CT-10 - Prestador de Serviço realiza cadastro |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-010 - A aplicação deve possuir uma área para cadastrar novos prestadores de serviços |
| Objetivos do teste | Validar se a aplicação está permitindo o cadastro de pessoas prestadoras de serviço |
| Passos | 1. abrir o navegador;<br> 2. acessar o endereço: https://www.xxxx.xx.xx;<br> 3. Navegar até o botão "Criar Conta" e pressioná-lo. <br> 4. Escolher a opção Prestador de Serviçoes;<br> 5. preencher todos os campos obrigatórios solicitado;<br> 6. pressionar o botão "Criar Conta".|
| Critério de êxito | Após o correto preenchimento do formulário e pressionar o botão cadastrar, o prestador de serviços deve conseguir fazer login com as credenciais cadastradas e ter acesso as funcionalidades da aplicação que exige login.<br> Se houverem campos não preenchidos o botão de cadastro deve estar desabilitado.<br> |

| Caso de Teste | CT-11 - Prestador de Serviço realiza login |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-008 - A aplicação deve possuir uma área de login para as empresas fazer a gestão de suas reservas<br> RF-011	A aplicação deve possuir dentro da área de login da empresa um resumo de feedback dos usuários.
| Objetivos do teste | Validar à área de login e se um prestador de serviços previamente cadastrado consegue logar-se. |
| Passos |1. abrir o navegador;<br> 2. acessar o endereço: https://www.xxxx.xx.xx;<br> 3. Navegar até o botão "Entrar" e pressioná-lo. Ou pelo botão "Login" no Menu <br> 4. inserir e-mail e senha válida;<br> 5. pressionar o botão "Entrar". |
| Critério de êxito | Após o preenchimento correto do e-mail e senha válidos e pressionar o botão "acessar" a pessoa prestadora de serviços deve ser direcionada para sua área logada. |

| Caso de Teste | CT-12 Prestador de Serviço cadastra um serviço |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-008 - A aplicação deve possuir uma área de login para as empresas fazer a gestão de suas reservas
| Objetivos do teste | Validar se um dono de estacionamento consegue cadastrar um novo estabelecimento |
| Passos |1. abrir o navegador;<br> 2. fazer o login como dono de estacionamento( referir-se à CT-11);<br> 3. No menu clicar no botão "Cadastrar Estacionamento" <br> 4. Fazer o preenchimento do formulário <br> 5. Clicar no botão "Cadastrar Estacionamento"! |
| Critério de êxito | Após o preenchimento correto do formulário e o clique no botão, espera-se que o serviço seja registrado com sucesso, passando a aparecer na listagem dos usuários e na tela de gerenciamento de serviços. <br> Não deve ser possível clicar no botão de cadastrar serviço sem o preenchimento completo do formulário. |

| Caso de Teste | CT-13 Prestador de Serviço remove um serviço |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-008 - A aplicação deve possuir uma área de login para as empresas fazer a gestão de suas reservas
| Objetivos do teste | Validar se um dono de estacionamento consegue remover um estabelecimento |
| Passos |1. abrir o navegador;<br> 2. fazer o login como dono de estacionamento( referir-se à CT-11);<br> 3. No menu clicar no botão "Gerenciar serviços cadastrados" <br> 4. Clicar no "Deletar serviço" <br> |
| Critério de êxito | Após o clique no botão, espera-se que o serviço não seja mais listado para usuários comuns ou na lista de serviços cadastrados do prestador de serviço. |

| Caso de Teste | CT-14  Prestador de Serviço atualiza um serviço |
| :-----------: | -------------------------------------------------------------- |
| Requisitos associados | RF-008 - A aplicação deve possuir uma área de login para as empresas fazer a gestão de suas reservas
| Objetivos do teste | Validar se um prestador de serviço consegue atualizar as informações um serviço |
| Passos |1. abrir o navegador;<br> 2. fazer o login como dono de estacionamento( referir-se à CT-11);<br> 3. No menu clicar no botão "Gerenciar serviços cadastrados" <br> 4. Clicar no botão "Atualizar serviço" <br> 5. Fazer o alterações no formulário <br> 6. Clicar no botão "Salvar alterações" |
| Critério de êxito | Após o preenchimento correto do formulário e o clique no botão, espera-se que o serviço seja atualizado com sucesso, passando a aparecer na listagem dos usuários e na tela de gerenciamento de serviços com as novas informações. <br> Não deve ser possível clicar no botão de salvar alterações sem o preenchimento completo do formulário. |
