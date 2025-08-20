# Lazy-Metal

## **1.Visão Geral**
**Tecnologias Utilizadas:** Unity 5;
**Descrição:** Implementação de um jogo no estilo plataforma com foco em solucionar puzzles para chegar até o fim do mapa.
**Objetivo:** criar um jogo funcional e minimamente interessante para praticar os princípios da programação orientada a objetos e adquirir experiência prática com a ferramenta Unity.

***

## **2.Descrição Detalhada do Projeto**

### **O que é o gênero plataforma?**

O genero plataforma se trata de um gênero de jogos focado na movimentção entre plataformas - normalmente flutuantes - que servem para desafiar o jogador. Esse estilo de jogo possui uma gama de fãs muito grande, 
principalmente nas comunidades de Speedrun (prática de tentar finalizar um jogo no menor intervao de tempo possível) por se tratar de um tipo de gameplaay mais memorizável e fácil de criar estratégias.

**Curiosidade:** surgiu na década de 80, com títulos como "Space Panic" e "Donkey Kong" estabelecendo as bases.

### **2.1 Funcionalidades Principais**

- **Motor do Jogo:**
  - Movimentação (direita, esquerda, saltar);
  - Detecção de colisões e sistema de gravidade próprio da engine Unity;
  - Sistema de checkpoints;
  - Sistema de Timer em tempo real mostrando o tempo de jogo atual (Interessante para speedruners).
    
- **Interface gráfica:**
  - Display do tempo jogado;
  - Renderização do mapa e do jogador;
  - Telas de início, pausa e game over.

- **Extras:**
  - Efeitos sonoros (Morte, Salto, trilha sonora contínua);

### **2.2 Arquitetura do Código**

  Lazy-Metal/

    Assets/
