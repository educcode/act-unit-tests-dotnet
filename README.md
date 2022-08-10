![](https://img.shields.io/static/v1?label=ACTIVITY&message=CONSTRUCTION-TESTES&color=<COLOR>)

✍🏽 Autor: Yan Justino  
📅 Data: 09/08/2022  
🇧🇷Idioma:  pt-br

### 📌 CONTEXTO

---

Sistemas de software são passivos de falhas, um vez que inconsistências e erros podem ser incorporados, de forma não
intencional, durante o processo de desenvolvimento. Nesse sentido, testes de software são importantes ferramentas para
auxiliar na gestão de qualidade de software. Dentre as estratégias de testes de software, os testes de unidade são um valioso
artefato pela sua fácil e rápida implementação. Sobre testes de unidade ainda podemos citar que:

- I. "Focaliza o esforço de verificação na menor unidade de projeto do software - o componente ou módulo de software...Enfoca
  a lógica interna de processamento e as estruturas de dados dentro dos limites de um componente." [1]


- II. "É o processo de testar componentes de programa, como os métodos ou as classes. deve se concentrar em testar a
  funcionalidade dos objetos e seus métodos". [2]


- III. "Verificam automaticamente pequenas partes de um código, normalmente uma classe apenas.
  São simples, fáceis de implementar e executam rapidamente". [3]

### 📗 ATIVIDADE

---

Essa atividade prover práticas de desenvolvimento de software com ênfase na estratégia de testes de unidade. Você deverá
evidenciar que é capaz de construir uma suíte de testes fazendo uso de técnicas e ferramentas. Para isso, você deve
realizar os passos a seguir:

1. Baixar esse repositório para sua máquina
2. Implementar na classe _BankAccount_ os seguintes métodos:
  3. `void withdraw(double value)`
  4. `void transfer(BankAccount beneficiaryAccount, double value)`
5. Escreva testes para as exceção disparadas nos métodos do ítem (2)
7. Implemente as seguintes cenários do teste BDD no arquivo _BankAccount.feature_

```
  Cenario: Retirada em um BankAccount com saldo
    Dado um BankAccount com saldo de R$ 100,00
    Quando retirar R$ 10,00
    Entao o saldo do BankAccount deve ser R$ 90,00

  Cenario: Transferencia em um BankAccount com saldo
    Dado um BankAccount com saldo de R$ 100,00
    E um BankAccount de destino com saldo de R$ 0,00
    Quando tranferir R$ 50,00 para o BankAccount de destino
    Entao o saldo do BankAccount deve ser R$ 50,00
    E o saldo do BankAccount de destino deve ser R$ 50,00
```

5. Publique os seu código em um repositório com um print dos testes passando.
6. Enviar link do repositório no fórum dessa atividade

### ⚠️ SOBRE ESSE REPOSITÓRIO

---

Esse repositório de código contém artefatos de software utilizados durante as
aulas da disciplina TIMD0147 - GERÊNCIA DE CONFIGURAÇÃO E TESTE DE SOFTWARE - T01 (2022.2), do INSTITUTO METROPOLE DIGITAL (IMD) / UFRN
. Nesse sentido, os códigos e aplicações da forma como estão aqui registrados devem ser
considerados como material utilizados para fins didáticos. Portanto, não representam uma sugestão ou insumo
que deva ser aplicada para soluções reais.

### 📖 REFERÊNCIAS

---

**[1]** PRESSMAN, Roger S; MAXIM, Bruce R. Engenharia de software: uma abordagem profissional. 8. ed. Porto Alegre: McGraw Hill, 2016. xxviii, 940 p. ISBN: 9788580555332.

**[2]** SOMMERVILLE, Ian. Engenharia de Software. 9.ed. São Paulo: Pearson, 2011. 529 p. ISBN: 9788579361081

**[3]** Marco Tulio Valente. 2020. Engenharia de Software Moderna: Princípios e Práticas para Desenvolvimento de Software com Produtividade (1st. ed.). Independente.

### 🔗 OUTRAS LEITURAS

---

- [The Practical Test Pyramid](https://martinfowler.com/articles/practical-test-pyramid.html)
- [CIO MAgazine - 15 Nov 2007 - Vol. 21, No. 4  (Revista)](https://books.google.com.br/books?id=YgoAAAAAMBAJ&lpg=PP1&pg=PP1#v=onepage&q&f=false)
- [Computerworld - 25 Jul 2005 - Vol. 39, No. 30  (Livro)](https://books.google.com.br/books?id=cPtooiQepS0C&printsec=frontcover#v=onepage&q&f=false)
- [CISQ SUPPLEMENTS ISO/IEC 25000 SERIES WITH AUTOMATED QUALITY CHARACTERISTIC MEASURES (Site)](https://www.it-cisq.org/cisq-supplements-isoiec-25000-series-with-automated-quality-characteristic-measures/)

