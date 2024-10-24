# Practica_4_II
Práctica 4 de la asignatura Interfaces Inteligentes. En esta práctica se profundiza en el uso de los eventos en Unity, realizando una serie ejercicios con el objetivo de aprender a utilizar los eventos, delegados, notificadores, observadores y comprender el patrón observador de Unity.
## Ejercicios Práctica 4
### Ejercicio 1
Se implementaron los siguientes scripts:
 - CilindroNotificador: Detecta colisiones con el cubo usando OnCollisionEnter y lanza el evento OnCilindroColision al colisionar.
 - EsferaTipo1: También se suscribe al mismo evento y, al activarse, se dirige hacia una esfera tipo 2 predefinida.
 - EsferasTipo2: Se suscribe al evento del cilindro. Al activarse, se mueve hacia el cilindro en el método Update.
 - MoverCubo: Permite mover el cubo con las teclas WASD aplicando fuerza al Rigidbody en FixedUpdate.
![practica_04_II-ejercicio_1](https://github.com/user-attachments/assets/78a79ea6-7027-46cd-87cd-d2430f9d2db5)

### Ejercicio 2
Se implementaron los siguientes scripts:
 - AranaTipo1: Se suscribe al evento de colisión del HuevoNotificador. Al activarse, mueve la araña tipo 1 hacia la araña tipo 2 usando AddForce en el Update.
 - AranaTipo2: Similar a AranaTipo1, se suscribe al mismo evento y, al activarse, se dirige hacia un objeto de tipo huevo utilizando AddForce.
 - HuevoNotificador: Detecta colisiones con el cubo mediante OnTriggerEnter. Al colisionar, lanza el evento OnHuevoColision si hay suscriptores, notificando a las arañas que deben moverse.
![practica_04_II-ejercicio_2](https://github.com/user-attachments/assets/a0864f82-c031-4802-9dae-db38f293e16d)

### Ejercicio 3
Reutilicé el script HuevoNotificador para las arañas tipo 1, ya que solo servían para indicar que hacer a las arañas del tipo 2.
 - arana_notificador: Detecta colisiones con el cubo usando OnTriggerEnter. Si hay colisión, lanza el evento OnAranaColision.
 - aranaHuevogrupo2: Se suscribe al evento de arana_notificador. Al activarse, mueve la araña hacia un objeto tipo huevo utilizando AddForce.
 - HuevoCambiaColor: Se suscribe al evento de HuevoNotificador2. Cambia el color del huevo al activarse, usando un color aleatorio.
 - HuevoNotificador2: Detecta colisiones físicas con el cubo usando OnCollisionEnter y lanza el evento OnHuevoColision si hay suscriptores.
![Practica_4_II_ej3](https://github.com/user-attachments/assets/9e88cf2c-84f6-4098-a94d-2bacd99928f5)

### Ejercicio 4
El script ProximidadCubo detecta si el cubo se acerca a un objeto de referencia. Si está dentro de la distancia de detección y el evento no se ha activado, teletransporta las arañas del grupo 1 al huevo objetivo y orienta las arañas del grupo 2 hacia un objetivo específico, ajustando su rotación. Un booleano (evento_activado) previene que el evento se active varias veces.
![practica_04_II-ejercicio_4](https://github.com/user-attachments/assets/7aada31d-f2f4-4bed-aa97-0182dbfc247c)

### Ejercicio 5
Scripts:
 - GestorDePuntos: Este script gestiona la puntuación total del jugador. Está suscrito al evento de recolección de huevos (del tipo de araña 1 y 2) mediante un sistema de eventos y delegados. Cada vez que se recoge una araña, se actualiza la puntuación total y se muestra en la consola.

 - ArañaTipo1 y ArañaTipo2: Estos scripts manejan la lógica de los huevos de araña cuando el cubo (jugador) los recolecta. Utilizan el método OnTriggerEnter para detectar la colisión con el cubo (tag "Player") y notifican al sistema la recolección de puntos (5 puntos para tipo 1 y 10 para tipo 2). Los huevos se destruyen después de la recolección.

 - NotificadorDeColisiones: Este script actúa como un notificador central. Define un evento que se dispara cuando se recolecta un huevo. Utiliza un delegado RecoleccionAraña para pasar los puntos al gestor de puntuación.
![practica_04_II-ejercicio_5](https://github.com/user-attachments/assets/c47bf7aa-768d-4e3e-b99d-3e7fd4790af5)

### Ejercicio 6
Se implementó un script ActualizadorDePuntuacionUI que actualiza la puntuación del jugador en la interfaz de usuario (UI) cuando se recolectan arañas. El script se suscribe a un evento de recolección y, al recibir puntos, actualiza un Text dentro del Canvas con la puntuación actual.
![practica_04_II-ejercicio_6](https://github.com/user-attachments/assets/7f3f2970-f0c8-404b-a807-b7403b15cf8d)

### Ejercicio 7
El script PuntuacionManager gestiona la puntuación del jugador y las recompensas. Inicializa los textos de puntuación y recompensas en la UI. El método SumarPuntos incrementa la puntuación y actualiza el texto en pantalla. Cada vez que el jugador alcanza múltiplos de 100 puntos, se muestra un mensaje de recompensa y se incrementa un contador para las recompensas. Además, se lanza un evento para notificar a otros componentes sobre la actualización de la puntuación.
![practica_04_II-ejercicio_7](https://github.com/user-attachments/assets/292b74ba-cd45-4682-86dd-ea0fdc288f2f)

### Ejercicio 8
El script PuntuacionManager gestiona la puntuación del jugador y las recompensas. Inicializa la puntuación y el contador en Start. En SumarPuntos, incrementa la puntuación y verifica si alcanza un múltiplo de 100 para mostrar una recompensa y hacer crecer una araña.
![practica_04_II-ejercicio_8](https://github.com/user-attachments/assets/c6389373-6fab-458a-8526-0ee6a2d383de)

### Ejercicio 9
En mi caso, en el ejercicio 3 ya implementaba el cubo como un objeto físico, siendo un trigger.
![Practica_4_II_ej3](https://github.com/user-attachments/assets/8edacca1-614f-4a5b-95a2-75dd2a89aa8e)

