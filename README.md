En este proyecto se estan utilizando 4 Patrones de diseño:
 
- Se utiliza un Singleton en el GameManager, este venia en el proyecto y se usa para muchas cuestiones del gameplay, para el porteo agrego la variable booleana TwoPlayer y gracias a este Singleton se aislan el comportamiento del segundo jugador.

- Se utiliza otro Singleton dentro del inputManager para poder definir los controles del juego desde las partes del juego que son necesarias (Gameplay, tutorial, Descarga).

- Se usa el Patron Observer para el manejo de la UI, este patron se implemento para que al modicarse el dinero obtenido este le avise a la UI y se modifique evitando que esta tenga que estar chequeando constantemente los valores e ir actualizandolos.

- Por ultimo tenemos un Patron Strategy, este lo usa el UIManager con el fin de definir si se utilizara UI para 1 o para 2 jugadores.
