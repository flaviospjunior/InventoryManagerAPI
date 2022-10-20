# Especificações do Projeto

## Personas

<table>
   <tr>
      <th>Foto</th>
      <th>História</th>
      <th>Aplicativos</th>
      <th>Hábitos</th>
   </tr>
   <tr>
      <td><img src="https://avatars.githubusercontent.com/u/9589046?v=4"/> </td>
      <td>Adelio Loureiro tem 57 anos,  possui um comércio de materiais de construção e ocupa seu tempo tocando seu pequeno negócio e realizando vendas para moradores da região. Adelio organiza suas vendas usando planilhas excel. </td>
      <td>
         <ul>
            <li>
               Facebook
            </li>
            <li>
               Whatsapp
            </li>
         </ul>
      </td>
      <td>
         <ul>
            <li>
               Participa de eventos relacionados a construção civil.
            </li>
            <li>
               Atua como gerente em sua pequena venda de materiais. 
            </li>
            <li>
               Conhece a comunidade local por ser um comerciante que atua há muito tempo no mesmo local.
            </li>
         </ul>
      </td>
   </tr>
     <tr>
      <td><img src="https://avatars.githubusercontent.com/u/219272?v=4"/> </td>
      <td>Wilson Guedes tem 34 anos,  engenheiro civil e trabalha como empresário no ramo de empreitadas de construção civil, Wilson é quem gerencia o estoque de sua equipe e é responsável por controlar entradas e saídas do estoque. </td>
      <td>
         <ul>
            <li>
               Instagram
            </li>
            <li>
               Whatsapp
            </li>
            <li>
               Trello
            </li>
         </ul>
      </td>
      <td>
         <ul>
            <li>
               Lidera sua equipe durante o dia de trabalho.
            </li>
            <li>
               Executa o controle de estoque de materiais utilizados por sua equipe. 
            </li>
            <li>
               Faz a gerência financeira de sua empresa. 
            </li>
         </ul>
      </td>
   </tr>
        <tr>
      <td><img src="https://avatars.githubusercontent.com/u/6477448?v=4"/> </td>
      <td>Pacheco Silva tem 32 anos e é  Professor e empresário, Pacheco realiza pequenas vendas de trabalhos artesanais que realiza nos horários vagos. </td>
      <td>
         <ul>
            <li>
               Google Planilhas
            </li>
            <li>
               Whatsapp
            </li>
            <li>
               LinkedIn
            </li>
         </ul>
      </td>
      <td>
         <ul>
            <li>
               Atua como professor em uma escola de ensino fundamental.
            </li>
            <li>
               Cria e vende pela internet objetos oriundos de sua atividade artesanal.  
            </li>
         </ul>
      </td>
   </tr>
</table>

 ## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
| Adelio Loureiro como comerciante| Quer digitalizar seu estoque | Para trazer agilidade em suas vendas e ter um controle de estoque confiável.
| Wilson Guedes como empresário| Quer um software simples para gestão de seus materiais| Facilitar a gestão de estoque para se dedicar às outras funções pertinentes à vida do empresário.
| Pacheco Silva como artesão| Quer controlar seu estoque para a atividade de artesanato de maneira barata| Para que seja possível substituir o estoque feito em planilhas google por um software mais simples.|
| Wilson Guedes como empresário| Quer visualizar a quantidade de materias cadastrados por categoria | Para gerencia-las da melhor forma possível.|

## Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001 |O sistema deve conter uma tela de cadastro | ALTA | 
|RF-002 |O sistema deve conter uma tela de login | ALTA |
|RF-003 |Permitir que o usuário possa cadastrar uma categoria de material | ALTA | 
|RF-004 |Permitir que o usuário possa cadastrar um material | ALTA |
|RF-005 |Permitir que o usuário possa editar um material| ALTA |
|RF-006 |Permitir que o usuário possa excluir um material| ALTA |
|RF-007 |Permitir que o usuário possa listar todos os materiais cadastrados | ALTA |
|RF-008 |Permitir que o usuário possa listar todos os materiais cadastrados por categoria | BAIXA |
|RF-009 |Permitir que o usuário possa fazer o upload de notas fiscais dos materiais | MÉDIA |
|RF-010 |O sistema deverá apresentar um log que contem alterações de usuários e os materiais alterados. | BAIXO |
|RF-011 |O sistema deve apresentar mensagem de confirmação de cadastro de materiais. |  ALTA | 


## Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema ser desenvolvido utilizando componentes da biblioteca Boostrap | MÉDIA | 
|RNF-002| A aplicação deverá ter o design amigável |  ALTA     | 
|RNF-003| Deve processar requisições do usuário em no máximo 5s |  MÉDIA    | 
|RNF-004| A aplicação deve ser responsivo |  ALTA     | 
|RNF-005| A aplicação ficará disponivel 24 horas por dia |  ALTA     | 
|RNF-006| O sistema será construído para rodar em ambiente web |  MÉDIA    | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O sistema não deve permitir o cadastro de materiais com código repetido |
|02| O sistema só deve permitir cadastro de usuários utilizando senhas fortes  |
|03| Apenas usuários administradores terão acesso ao menu de cadastro de categorias |
|04| O sistema deve permitir apenas um cadastro por email de usuário |
|05| O projeto deverá ser entregue até o final do semestre |
|06| Primeira versão será lançada apenas Web |
