# 🏨 Sistema de Hospedagem - Desafio de LAB

Este projeto consiste em um sistema simples de **reserva de hospedagens** em um hotel, desenvolvido como parte de um desafio proposto em laboratório de programação. O sistema utiliza três classes principais:

- `Guest`: representa o hóspede.
- `Suite`: representa as suítes do hotel.
- `Reserve`: relaciona hóspedes e suítes, calculando valores e regras de estadia.

## 📌 Requisitos do Desafio

- Criar uma classe `Guest` com os dados do hóspede.
- Criar uma classe `Suite` com informações sobre a acomodação.
- Criar uma classe `Reserve` que faça o relacionamento entre `Guest` e `Suite`.
- Calcular corretamente:
  - A **quantidade de hóspedes**.
  - O **valor da diária**, com a seguinte regra:
  - Se a reserva for por mais de **10 dias**, aplicar **10% de desconto** no valor total.
