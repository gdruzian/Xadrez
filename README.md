# ♟️ Jogo de Xadrez em Console (C# .NET)

![Badge em Desenvolvimento](http://img.shields.io/static/v1?label=STATUS&message=CONCLUIDO&color=GREEN&style=for-the-badge)
![Badge .NET](https://img.shields.io/static/v1?label=.NET&message=8.0&color=blue&style=for-the-badge)

## 💻 Sobre o Projeto

Este projeto consiste num **Motor de Xadrez (Chess Engine)** completo desenvolvido em C# puro, rodando via Console. O objetivo principal foi aplicar na prática os conceitos avançados de **Programação Orientada a Objetos (POO)** e lógica de programação complexa.

O sistema é capaz de identificar jogadas válidas, capturar peças, reconhecer situações de **Xeque** e **Xeque-Mate**, além de validar movimentos especiais.

## 📸 Demonstração

<div align="center">
  <img src="https://github.com/user-attachments/assets/9a3f553b-8518-4100-bc32-7e7c2adb3f9f" alt="Demonstração do Tabuleiro" width="600">
</div>

## ✨ Funcionalidades

- **Tabuleiro Dinâmico:** Impressão do tabuleiro no console com cores diferentes para peças brancas e pretas (fundo alterado para melhor visualização).
- **Movimentação Validada:** O sistema impede movimentos que não obedecem às regras do xadrez ou que coloquem o próprio Rei em xeque.
- **Jogadas Especiais Implementadas:**
  - 🏰 **Roque:** Pequeno e Grande.
  - ♟️ **En Passant:** Captura especial de peões.
  - 👑 **Promoção:** O peão vira outra peça ao chegar ao final do tabuleiro.
- **Tratamento de Erros:** Sistema robusto de exceções para impedir inputs inválidos do utilizador.
- **Turnos:** Controle de quem joga (Brancas/Pretas) e contagem de turnos.

## 🛠️ Tecnologias Utilizadas

- **C#** (Linguagem Principal)
- **.NET 8.0** (Framework)
- **Visual Studio 2022** (IDE)

## 🧠 Conceitos Aprendidos e Aplicados

Este projeto foi fundamental para consolidar conhecimentos em:

- **Encapsulamento, Herança e Polimorfismo:** Criação de classes genéricas (`Peca`, `Tabuleiro`) e especializadas (`Rei`, `Torre`, `Peao`).
- **Matrizes e Lógica Matemática:** Manipulação de posições no tabuleiro (Matriz 8x8).
- **Membros Estáticos:** Métodos e atributos de classe.
- **Tratamento de Exceções:** Uso de `try-catch` para garantir que o programa não pare ("crash") diante de um erro do usuário.
- **Sobrecarga:** Métodos com assinaturas diferentes para flexibilidade.

## 🚀 Como Executar

### Pré-requisitos
Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.

```bash
# Clone este repositório
$ git clone https://github.com/gdruzian/Xadrez.git

# Acesse a pasta do projeto no terminal/cmd
$ cd Xadrez

# Execute o projeto
$ dotnet run
