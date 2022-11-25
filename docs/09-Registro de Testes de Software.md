# Registro de Testes de Software

## 1ª Leva de Testes

A primeira leva de testes foi realizada entre os dias 28 e 30 de Outubro de 2022. As conclusões que foram encontradas são as sequintes:

### CT-01 - Encontrar um Estacionamento por meio do campo de busca

Não existe um campo de busca, assim portanto não houve êxito no teste.

![image](https://user-images.githubusercontent.com/41563209/198900497-c63b99b9-8f93-4e06-b843-f8752fe290b1.png)
Fig 1: Tela inicial

### CT-02 - Usuário faz busca de estabelecimento por meio de filtros

Não existe um campo de busca, portanto não é possível que o usuário realize uma busca de estabelecimentos por meio de filtros

![image](https://user-images.githubusercontent.com/41563209/198900538-e24bff08-c52a-4860-9560-01c23fd33e1d.png)
Fig 2: Tela inicial

### CT-03 Usuário comum realiza cadastro e CT-04 Usuário comum realiza login

Após o usuário entrar na página principal e se cadastrar, o login com as informações cadastradas não é suficiente para realizar o login. Logo após a tentativa de login, as infromações da página de login somem e não é concedido o acesso do usuário a aplicação.
No exemplo, foi inserido o cadastro o usuário e as mesmas informações para login, e não obteve sucesso em realizar o login

![image](https://user-images.githubusercontent.com/41563209/198900610-4dce99ac-0d56-437b-9ecd-12d3f401d055.png)
Fig 3: Tela de cadastro

![image](https://user-images.githubusercontent.com/41563209/198900637-a4986f5a-e8a4-4186-90d2-6d90cd861fb6.png)
Fig 4: Tela de log in

![image](https://user-images.githubusercontent.com/41563209/198900668-01b9b4cb-4a93-48ca-8bf4-b1076896acb0.png)
Fig 5: Tela de log in para uma segunda tentativa para a senha cadastrada


## 2ª Leva de Testes

A segunda leva de testes foi realizada entre os dias 24 de Novembro de 2022 e 25 de Novembro de 2022

### CT-01 - Encontrar um Estacionamento por meio do campo de busca

O teste foi parcialmente sucedido, os estacionamentos são filtrados por seu nome inteiro ou por partes do nome, contudo ao clicar no botão de pesquisar sem nada escrito no campo de pesquisa, ocorre um erro não tratado; a tela então é redirecionada para uma tela de erro genérica

![resultados-da-busca](https://user-images.githubusercontent.com/86004024/204054684-a3e9fd33-cbfd-465c-b7a5-4eef61bc111e.png)
Fig 1-B: Tela de resultados de busca

### CT-02 - Usuário faz busca de estabelecimento por meio de filtros

O teste foi bem sucedido, ao preencher os filtros a busca é feita à partir dos parametros. Foi constatado também que a usabilidade não ficou muito boa nesse preenchimento, não existe designação dos campos que são obrigatórios para a filtragem e os opcionais
![cb3994f2e9bf7e5b7b0926d3e2a719f4](https://user-images.githubusercontent.com/86004024/204054795-4f895ad0-c221-4d24-a526-8f9e176d7643.png)
Fig 2-B: Filtros para busca

![91ff4600b823f64bf3c2af13e1eac6f6](https://user-images.githubusercontent.com/86004024/204054918-46a231b8-290f-40ea-b5bd-ba9fee257831.png)
Fig 2-C: Resultado da busca

### CT-03 Usuário comum realiza cadastro

O teste foi bem sucedido, após o preenchimento dos campos de Email, Nome completo e Senha; e ao apertar o botão Criar conta é averiguada a criação de um novo item de usuário no banco de dados e o login com os dados preenchidos é possivel

![c5ea1be4d5f0c2c12252562b7ed2ad4a](https://user-images.githubusercontent.com/86004024/204055196-e206bc3e-3974-41b0-9099-230f5ecf066d.png)
Fig 6: Tela de cadastro

### CT-04 Usuário comum realiza login

O teste foi bem sucedio, com dados preenchidos no CT-03, é possível fazer o login e avançar para a Área principal do cliente.

![003383f8f44b3f01470ef48d0a5b09a8](https://user-images.githubusercontent.com/86004024/204054513-13cbfd6c-05fe-43dd-94a4-248f6ffa99d2.png)
Fig 7: Tela de Aréa Principal do Cliente

### CT-05 Dono de Estacionamento realiza cadastro

O teste foi bem sucedido, após o preenchimento dos campos de Email, Nome completo e Senha; e ao apertar o botão Criar conta é averiguada a criação de um novo item de dono de estacionamento no banco de dados e o login com os dados preenchidos é possivel.

![a41bd423e85fd2e6dcc130acd0c8c739](https://user-images.githubusercontent.com/86004024/204055130-c90fa92a-4064-4634-b4fd-2dca0ca227ab.png)
Fig 8: Tela de cadastro(dono de estacionamento)

### CT-06 Dono de Estacionamento realiza login

O teste foi bem sucedio, com dados preenchidos no CT-05, é possível fazer o login e avançar para a Área do administrador.

Fig 9: Tela de login(dono de estacionamento)

### CT-07 Dono de Estacionamento cadastra um estacionamento

O teste foi parcialmente sucedido, ao preencher corretamente todos os campos o cadastro de um estacionamento é feito com êxito, contudo, se os campos não forem preenchidos ou forem preenchidos incorretamente, não existe algum tratamento por parte da aplicação, ocorrendo redirecionamento para uma tela de 'erros genérica' ou o cadastro de dados absurdos (quando o numero de vagas totais é menor que o numero de vagas preferenciais, por exemplo).

![formulario-de-cadastro-de-estacionamento](https://user-images.githubusercontent.com/86004024/204051025-5d617686-729d-4f5e-ab04-ac829675d126.png)
Fig 10: Tela de cadastro de estacionamentos

![dados-estacionamento-numeros-absurdos](https://user-images.githubusercontent.com/86004024/204050689-2e927257-621b-4f9e-917e-4c07793bfd5f.png)
Fig 11: Estacionamento cadastrado com números absurdos

![dados-estacionamento-cadastrado-normalmente](https://user-images.githubusercontent.com/86004024/204050879-0bc0e729-7fc9-49af-a8f4-89abde0ec3c5.png)
Fig 12: Estacionamento cadastrado normalmente

![bce3809ebd1b1c20443574fdf744cae9](https://user-images.githubusercontent.com/86004024/204051793-71e9b4aa-9149-4fca-9f42-68ea8b3a3dd3.png)
Fig 13: Tela de erro generica

### CT-08 Dono de Estacionamento remove um estacionamento

O teste foi bem sucedido, o dono de estacionamento consegue remover um de seus estacionamentos geridos. Após isso ele não é mais listado na aplicação

![mensagem-estacionamento-removido-com-sucesso](https://user-images.githubusercontent.com/86004024/204051465-10014817-c5c9-4b8b-9c10-13f03b985b19.png)
Fig 14: Estacionamento removido

### CT-09 Dono de Estacionamento atualiza um estacionamento

O teste foi parcialmente sucedido, ao preencher corretamente todos os campos a atualização de um estacionamento é feito com êxito, contudo, se os campos não forem preenchidos ou forem preenchidos incorretamente, não existe algum tratamento por parte da aplicação, ocorrendo redirecionamento para uma tela de 'erros genérica' ou o cadastro de dados absurdos (quando o numero de vagas totais é menor que o numero de vagas preferenciais, por exemplo).

![1d374ec70c3ac81f7ae93a9febf33b06](https://user-images.githubusercontent.com/86004024/204051907-d5c6ae28-c8b7-48a0-9d8b-bb47b7d40e6a.png)
Fig 15: Estacionamento atualizado

### CT-10 Prestador de Serviço realiza cadastro

O teste foi bem sucedido, após o preenchimento dos campos de Email, Nome completo e Senha; e ao apertar o botão Criar conta é averiguada a criação de um novo item de dono de estacionamento no banco de dados e o login com os dados preenchidos é possivel.

![10bcaedb2663e9590b24ac600e1c627e](https://user-images.githubusercontent.com/86004024/204055095-b956b5b5-8ff6-486a-b8b3-e06e45d865b8.png)
Fig 16: Tela de cadastro(prestador de serviço)

### CT-11 Prestador de Serviço realiza login

O teste foi bem sucedio, com dados preenchidos no CT-05, é possível fazer o login e avançar para a Área do administrador.

![tela-prestador-serviço](https://user-images.githubusercontent.com/86004024/204052106-9ff1d54b-b681-45a4-90d3-e512dab8bec2.png)
Fig 17: Tela de Início(prestador de serviço)

### CT-12 Prestador de Serviço cadastra um serviço

O teste foi parcialmente sucedido, ao preencher corretamente todos os campos, o cadastro de um serviço é feito com êxito, contudo, se os campos não forem preenchidos, não existe algum tratamento por parte da aplicação, ocorrendo redirecionamento para uma tela de 'erros genérica'.

![formulario-de-cadastro-de-servicos](https://user-images.githubusercontent.com/86004024/204052379-9f1b6d82-b38a-4556-afe6-c83213acdff7.png)
Fig 18: Tela de cadastro de serviços

![serviço-cadastrado](https://user-images.githubusercontent.com/86004024/204052690-814dac93-4f3b-494f-ac6a-e5a4dfcf817f.png)
Fig 19: Serviço cadastrado normalmente

![dados-serviço-cadastrado](https://user-images.githubusercontent.com/86004024/204052736-30c46f65-473e-46cb-81e3-19122879443a.png)
Fig 20: Dados do serviço cadastrado

![tela-de-erro-generica](https://user-images.githubusercontent.com/86004024/204052576-4d2b63ff-bead-4014-a887-81fb2da0cd43.png)
Fig 21: Tela de erro generica

### CT-13 Prestador de Serviços remove um serviço

O teste foi bem sucedido, o prestador consegue remover um de seus serviços geridos. Após isso ele não é mais listado na aplicação

![mensagem-estacionamento-removido-com-sucesso](https://user-images.githubusercontent.com/86004024/204051465-10014817-c5c9-4b8b-9c10-13f03b985b19.png)
Fig 22: Estacionamento removido

### CT-14 Prestador de Serviços atualiza um serviço

O teste foi parcialmente sucedido, ao preencher corretamente todos os campos, a atualizção de um serviço é feita com êxito, contudo, se os campos não forem preenchidos, não existe algum tratamento por parte da aplicação, ocorrendo redirecionamento para uma tela de 'erros genérica'.

![image](https://user-images.githubusercontent.com/86004024/204054079-47b43510-90fb-4790-a2f0-ee0c4eb8c58a.png)
Fig 23: Serviço atualizado
