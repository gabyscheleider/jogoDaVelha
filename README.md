# 🕹️ Jogo da Velha Full Stack

Este é um projeto Full Stack de um **Jogo da Velha (Tic Tac Toe)** desenvolvido com **React + TypeScript** no frontend e **ASP.NET Core (C#)** com **PostgreSQL** no backend.

O objetivo principal do projeto é permitir que usuários joguem partidas de Jogo da Velha com interface interativa e armazenar os resultados no banco de dados.

## 🚀 Tecnologias Utilizadas

### Frontend
- React
- TypeScript
- Axios
- Tailwind CSS (se estiver usando)

### Backend
- ASP.NET Core (C#)
- Entity Framework Core
- PostgreSQL

## 🧠 Funcionalidades
- Jogar partidas de Jogo da Velha
- Registrar partidas no banco de dados
- Visualizar histórico de jogos (em construção ou implementado)

## 📦 Estrutura do Projeto

/frontend → Interface do usuário com React
/backend → API em C# com ASP.NET Core

## 📌 Como Rodar o Projeto

git clone https://github.com/seu-usuario/seu-repositorio.git


### Backend
    ✅ Pré-requisitos
    - .NET SDK 7.0+
    - PostgreSQL
    - Ferramenta de API como Postman (opcional, para testar)
    
1. Navegue até a pasta `backend`:
```bash
    cd backend

    dotnet restore

Configure o appsettings.json

    "ConnectionStrings": {
        "DefaultConnection": "Host=localhost;Port=5432;Database=jogodavelha;Username=seu_usuario;Password=sua_senha"
    }

    dotnet ef database update

    dotnet run

### frontend
    cd ../frontend
    npm install
    npm run dev
