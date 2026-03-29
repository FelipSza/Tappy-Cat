# Tappy-Cat 🐱🎮

> **Status:** Projeto de Estudo Concluído ✅ / Resta polimento.

O **Tappy-Cat** é um "endless runner" inspirado no clássico *Flappy Bird*. Este foi o meu ponto de partida no desenvolvimento de jogos, servindo como laboratório para entender a integração entre a **Unity Engine** e a linguagem **C#**.

O foco principal foi a implementação de um loop de jogabilidade fluido e o gerenciamento eficiente de objetos em cena.

---

## 🕹️ Funcionalidades

* **Mecânica de Pulo:** Controle de física via `AddForce` para simular o impulso do personagem.
* **Geração Infinita:** Sistema de *spawner* que gerencia a criação e destruição de obstáculos para otimizar o uso de memória.
* **Sistema de Pontuação:** Gatilhos (*Triggers*) que detectam a passagem do jogador e atualizam a UI em tempo real.
* **Game Loop Completo:** Telas de início, game over e reinicialização de cena.

## 🛠️ Tecnologias Utilizadas

* **Engine:** [Unity](https://unity.com/)
* **Linguagem:** [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/) (.NET Standard)
* **Componentes-Chave:** `Rigidbody2D`, `BoxCollider2D`, `Unity Events` e `SceneManagement`.

---

## 🚀 Como Testar

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/FelipSza/Tappy-Cat.git](https://github.com/FelipSza/Tappy-Cat.git)
    ```
2.  Abra a pasta no **Unity Hub**.
3.  Localize a cena principal em `Assets/Scenes/SampleScene.unity`.
4.  Clique no botão **Play**.

---

## 📚 Créditos

Este projeto foi desenvolvido acompanhando o guia técnico de:

* **Canal:** [Zigurous](https://www.youtube.com/@Zigurous)
* **Vídeo:** [How to make Flappy Bird in Unity](https://www.youtube.com/watch?v=XtQMytORBmM)
