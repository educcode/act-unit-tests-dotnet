# language: pt

Funcionalidade: Operações em BankAccount
Devem atualizar o saldo de forma correta

    Cenario: Deposito em um BankAccount
        Dado um BankAccount com saldo de R$ 0,00
        Quando depositar R$ 10,00
        Entao o saldo do BankAccount deve ser R$ 10,00
        
    Cenario: Deposito em um BankAccount com saldo
        Dado um BankAccount com saldo de R$ 10,00
        Quando depositar R$ 10,00
        Entao o saldo do BankAccount deve ser R$ 20,00

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