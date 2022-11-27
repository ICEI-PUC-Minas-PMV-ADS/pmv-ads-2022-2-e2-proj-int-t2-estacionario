# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

![Diagrama de Classes](img/DiagramaDeClasses_ver2.png)

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

![Modelo ER (Projeto Conceitual)](img/ModeloER_ver2.jpeg)

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.

![Projeto da Base de Dados](img/ProjetoBaseDados.jpg)

## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Diagrama de Fluxo de Usuários

![diagrama_flluxos_usuarios](https://user-images.githubusercontent.com/86004024/193414659-504cb3bf-0010-4802-9aa5-85a6f784a558.png)


## Hospedagem

A aplicação está hospedada na https://www.smarterasp.net/ em uma conta gratuita de 60 dias.

Foi realizada a inclusão do banco de dados, criado no Microsoft SQL Server, e a atualização do appsetting.json para a inclusão do ConnectionString que vincula a aplicação no novo local do banco de dados. Após essa atualização, foi feito a inclução dos códigos no site da smartarasp.net.

O endereço que está a aplicação é o http://fernends-001-site1.itempurl.com
