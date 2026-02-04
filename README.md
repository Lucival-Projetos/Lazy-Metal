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
    
- **Interface gráfica:**
  - Renderização do mapa e do jogador;
  - Telas de início, e de finalização.

- **Extras:**
  - Trilha sonora ontínua.

### **2.2 Arquitetura do Código**

    Lazy-Metal/
  
      Assets/ #todos os itens utilizados no jogo, sejam gráficos ou códigos, dentre eles, sons, scripts, sprites.
      
        Scripts/ #local onde armazeno os códigos do jogo
        
          
        Pallete/ #local para guardar as paletas do sistema de tilemap do Unity
        
          Tiles/ # pasta dentro de Pellete para guardar cada tile (uma dessa para cada tilemap)

        


## **3. Etapas de Entrega (Cronograma Detalhado)**

### **~Etapa 1: Protótipo Básico (Bimestre 1)~** **Já entregue**

### **~Etapa 2: Lógica do Jogo (Bimestre 2)~** **já entregue**


### **Etapa 3: Mecânicas básicas (Bimestre 3)**
- primeira sala;
- movimentação e pulo;
- animações;
- menu inicial;
- botões quit e start.

## **Etapa 4: Testes e Entrega Final (Bimestre 4)**
- Testes e correção de bugs;
- Tela de finalização;
- Efeitos sonoros.


## **4. Requisitos técnicos**

- Unity (2022.3.62f1)
