# Escenas Cardboard

Esther Jorge Paramio

#### Crear una aplicación Unity con cubos y esferas y la convertirla en una aplicación VR. 

Para el uso de Cardboards, creamos un proyecto de Unity en 3D y lo convertimos en un aplicación VR. Para ello, realizamos los siguientes pasos:

- Descargamos el paquete *GoogleVRForUnity_1.200.1.unitypackage* y lo importamos a nuestro proyecto. 
- Vamos a ```Build Settings```, pulsemos en *Android* y seleccionamos ```Switch Platform``` para poder desarrollar nuestro proyecto en dispositivos *Android*.
- Ahora, vamos a ```Player Settings``` que se encuentra en la misma pestaña que hemos abierto en el paso anterior y en ```Player``` y seleccionamos ```XR Settings > Virtual Reality Supported``` para que nuestra aplicación soporte aplicaciones de realidad virtual.
- En la misma pestaña del paso anterior, en ```Virtual Reality SDks``` y en la *+* añadimos ```Cardboard```.
- A continuación, en la misma ventana, nos vamos a ```Other Settings > Vulkan``` y le damos al *-* para eliminarlo. Además, añadimos con el *+* ```OpenGLES2``` y eliminamos ```OpenGLES3``` porque la primera soporta versiones antiguas.
- Cerramos todas las ventanas anteriores y nos dirigimos a *SampleScenes*. Creamos un objeto vacío y le ponemos como hijo la cámara principal, una vez hecho esto, en el reseteamos el *transform* de *MainCamera* desde el inspector de objetos.
- Luego, en la raíz añadimos buscando en *Project* el *gameObject* *GvrEditorEmulator* y si ejecutamos el programa podemos mover la cámara en los ejes *X* y *Z* con *alt + ratón* y en el eje *Y* con *ctrl + ratón*. Esto hará que desde el móvil se pueda mover según el movimiento de nuestra cabeza.
- A continuación, le añadimos como hija de la *MainCamera* el *gameObject* *GvrReticlePointer*. Esto añadirá un punto en la pantalla que representará la retícula del ojo a la cual se le podrá cambiar de color. 
- Por último, para realizar eventos varios en función a la retícula del ojo, en la raíz añadimos también el *gameObject* *GvrEventSystem*.

Realizando los pasos anteriores en orden, tendremos nuestro proyecto listo para crear una aplicación para Android de realidad virtual.

#### El jugador podrá recolectar cubos y cambiar de color las esferas. Inicialmente las esferas serán blancas y el nuevo color debe eligirlo entre 3 opciones en la UI.

Para este punto, colocamos 
