# Plano de Testes de Software

| CASO DE TESTE         | VALIDAÇÃO DE LOGIN                                                                                                                            |
| --------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF05 - Tela de login e funcionalidade de login do usupario                                     |
| Objetivo do Teste     | Autenticar corretamente diversos usuários cadastrados para acessar a solução.                                                                 |
| Passos                | 1)Digitar usuário e senha e, posteriormente, clicar no botão ENTRAR|
|Critérios de Êxito     | Os usuários precisam ser redirecionados para a página inicial da aplicação uma vez que o usuário e senha estejam de acordo com os dados cadastrados previamente.|


| CASO DE TESTE         | OPERAÇÕES DO USUÁRIO                                                                                                                    |
| --------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-003, RF-004, RF-011 O usuário poderá cadastrar materiais e categorias de materiais de acordo com sua necessidade, o material exige previamente o cadastro de ao menos uma categoria de material        |
| Objetivo do Teste     | Verificar se os cadastros são realizados corretamente e persistidos na base de dados além de apresentar mensagem com a informação de sucesso ou falha no cadastro.   |
| Critérios de Êxito    | Os usuários devem conseguir cadastrar e posteriormente listar tanto o material quanto a categoria de material cadastrada |

| CASO DE TESTE         | OPERAÇÕES DO USUÁRIO                                                                                                              |
| --------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-004, RF-008 - O usuário, poderá listar todos os materiais e categorias de materiais previamente cadastrados |
| Objetivo do Teste     | Verificar se a listagem apresentada em tela corresponde ao que está persistido no banco de dados.
| Passos                | 1) Após logar acessar o menu correspondente a material e a categoria de material 2) Verificar se todos os materiais e categorias de materiais presentes em suas respectivas telas estão sendo listados. |
| Critérios de Êxito    | Todos os materiais ou categorias de materiais presentes na base de dados devem ser listados em tela. |

| CASO DE TESTE         | OPERAÇÕES DO USUÁRIO                                                                                                                          |
| --------------------- |--------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos associados | RF-009 - O usuário deve conseguir fazer o upload e associar uma nota fiscal ao material                       |
| Objetivo do Teste     | Testar o upload de uma nota fiscal para um determinado material.                               |
| Passos                | 1)Editar algum material 2) Acessar o botão "Upload NF" 3) Selecionar o arquivo de nota fiscal|
| Critérios de Êxito | Após o Upload da nota fiscal, esta deverá permanecer associada ao material em questão.|

| CASO DE TESTE         | OPERAÇÕES DO USUÁRIO                                                                                                                          |
| --------------------- |--------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos associados | RNF-004 - A interface deve ser agradável e de fácil utilização, além de ser responsiva para uso em smartphones.                         |
| Objetivo do Teste     | Testar a responsividade da aplicação em um smartphone. Ademais, verificar se a interface é de facil utilização.                               |
| Passos                | 1)Ao utilizar um smartphone deve-se verificar se há ocorrência de problemas com a aplicação.2)Verificar a facil utilização da aplicação a partir da ótica de um terceiro.|
| Critérios de Êxito | Ao utilizar um smartphone não deve haver nenhum erro responsivo. |
