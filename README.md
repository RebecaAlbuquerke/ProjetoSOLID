# ProjetoSOLID
Esse projeto consiste em um projeto de estudos para mostrar os Principios SOLID sendo aplicados e não aplicados.

## SRP (Princípio da responsabilidade única)
Uma classe, um método, um arquivo, um evento só tem uma responsabilidade. A classe não deve adicionar recurso, isso é responsabilidade do repositório. Esse princípio possibilita reaproveitamento de código, testes automatizados, refatoração e menos bugs.

## OCP (Princípio Aberto-Fechado)
Classes, entidades e funções devem estar abertas a extensões e fechadas para modificação. A base não deve mudar.

## LSP (Princípio da substituição de Liskov)
Uma classe base deve poder ser substituída por sua classe derivada. Substituir a classe pai pela classe filha.

## ISP (Princípio da segregação de interface)
SRP aplicado a classes. Muitas interfaces específicas são melhores do que uma única interface.

## DIP (Princípio da inversão de dependência)
Módulos de alto nível não devem depender de módulos de baixo nível, ambos devem depender de abstrações. As abstrações não devem depender dos detalhes e sim os detalhes devem depender da abstração. Deve-se depender de uma abstração e não de uma implementação.
