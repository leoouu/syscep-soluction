# SYSCEP - Sistema de Cadastro de Estrutura Pedagógica

Sistema de gerenciamento acadêmico desenvolvido em C# com arquitetura MVC (Model-View-Controller) para cadastro e controle de estruturas pedagógicas de cursos. 

## 📋 Sobre o Projeto

O SYSCEP é uma aplicação de console que permite gerenciar: 

- **Períodos** - Cadastro de períodos letivos (semestres, trimestres, etc.)
- **Cursos** - Cadastro de cursos oferecidos pela instituição
- **Disciplinas** - Cadastro de disciplinas/matérias
- **Disciplina-Curso** - Vinculação de disciplinas aos cursos

## 🏗️ Arquitetura

O projeto segue o padrão **MVC** dividido em 4 camadas:

```
syscep-soluction/
├── syscep/              # Projeto principal (Entry Point)
│   └── Program.cs
├── syscepmodel/         # Camada de Modelo (Entidades)
│   ├── Periodos.cs
│   ├── Cursos.cs
│   ├── Disciplinas.cs
│   └── DisciplinaCurso.cs
├── syscepview/          # Camada de Visualização (Interface)
│   └── Menu.cs
└── syscepcontroller/    # Camada de Controle (Lógica de Negócio)
    ├── Periodo.cs
    ├── Curso.cs
    ├── Disciplina.cs
    └── DisciplinaCursos.cs
```

## 🚀 Funcionalidades

Cada módulo oferece as seguintes operações (CRUD):

| Operação   | Descrição                        |
|------------|----------------------------------|
| Inserir    | Adiciona um novo registro        |
| Alterar    | Modifica um registro existente   |
| Excluir    | Remove um registro               |
| Pesquisar  | Busca um registro específico     |
| Exibir     | Lista todos os registros         |

## 💾 Persistência de Dados

Os dados são salvos automaticamente em arquivos **CSV** ao encerrar o programa, garantindo que as informações sejam mantidas entre as execuções.

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **.NET Framework**
- **Arquitetura:** MVC (Model-View-Controller)
- **Interface:** Console Application
- **Persistência:** Arquivos CSV

## ▶️ Como Executar

1. Clone o repositório: 
   ```bash
   git clone https://github.com/leoouu/syscep-soluction.git
   ```

2. Abra a solução no Visual Studio

3. Compile e execute o projeto `syscep`

4. Navegue pelo menu utilizando as opções numéricas

## 📖 Uso

Ao iniciar o programa, você verá o menu principal com as opções:

```
1. PERÍODOS
2. CURSOS
3. DISCIPLINAS
4. DISCIPLINA-CURSO
9. SAIR
```

Selecione uma opção para acessar o submenu correspondente com as operações CRUD disponíveis.
