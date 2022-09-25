En este proyecto se estan utilizando 4 Patrones de diseño:
 
- Se utiliza un Singleton en el GameManager, este venia en el proyecto y se usa para muchas cuestiones del gameplay, para el porteo agrego la variable booleana TwoPlayer y gracias a este Singleton se aislan el comportamiento del segundo jugador.
Gracias a que solo tiene que existir 1 solo gameManager es posible hacer esto y facilitar la comunicacion entre Scrips, y dentro de todos las funciones que tenia el proyecto original, luego del porteo resuelve el problemas del comportamiento del segundo jugador cuando estas en SinglePlayer.

- Se utiliza otro Singleton dentro del inputManager para poder definir los controles del juego desde las partes del juego que son necesarias (Gameplay, tutorial, Descarga).
Ya que solo vamos a manejar el Input desde un solo lugar que sera el InputManager podemos hacer un singlenton que nos facilite el poder detectar input desde distintas partes del codigo y encapsulando asi todo lo que es el input, los distintos componentes detectaran acciones y luego se las envia al InputManager para que este decida que entrada va a ser la que realice tal accion.

- Se usa el Patron Observer para el manejo de la UI, tanto como el Player como el ControladorDeDescarga luego de modificar el dinero actual que tiene el jugador daran aviso a la UI para que esta se actualice, esto ayuda al desacoplamiento ya que la UI no conoce al jugador y esto evita que la misma chequee el dinero actual del jugador todos los frames, accion que es innesesaria cuando el dinero que tiene es el mismo, solo se debe actualizar cuando este cambie. 

- Por ultimo tenemos un Patron Strategy, este lo usa el UIManager que mediante la interfaz IUIMgrPlayerCount tiene las clases concretas de UIMgrOnePlayer y UIMgrTwoPlayer que luego al iniciar el gameplay y gracias al singlenton del GameManager es que la UI se define y se elige una estrategia u otra. Esto se hace para resolver el problema de la UI de singlePlayer no es la misma que la del multiplayer y aca tenemos una forma dinamica de identificar en cual estamos.
