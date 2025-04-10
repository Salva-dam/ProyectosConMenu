# ProyectosConMenu

## Descripción del Proyecto
**ProyectosConMenu** es una colección de ejercicios prácticos en C# que incluye varios juegos y herramientas desarrollados como parte de un aprendizaje de programación. El proyecto proporciona una interfaz de consola que permite interactuar con una serie de juegos, herramientas y ejercicios, todo accesible desde un menú principal.

### Ejercicios incluidos:
1. **Agenda de Contactos**: Permite agregar, mostrar y buscar contactos en una agenda digital.
2. **Generador de Contraseñas**: Genera contraseñas seguras con diferentes longitudes y complejidades.
3. **Adivina el Número**: Un juego en el que el usuario tiene que adivinar un número aleatorio.
4. **Diccionario Juego**: Un juego en el que el usuario tiene que adivinar la definición de una palabra.
5. **Juego de Memoria**: Un juego en el que el usuario debe recordar una palabra mostrada brevemente y adivinarla correctamente.

## Instrucciones de Instalación

### 1. Clonar el repositorio
Clona este repositorio en tu máquina local utilizando el siguiente comando:

```
git clone https://github.com/tu-usuario/ProyectosConMenu.git
```

### 2. Instalar .NET SDK
Este proyecto requiere el SDK de .NET 9.0. Asegúrate de tenerlo instalado en tu máquina. Para instalarlo, puedes seguir los pasos oficiales en la página de instalación de .NET.
[https://dotnet.microsoft.com/download/dotnet](URL)


Para verificar si ya tienes .NET instalado, ejecuta:
```
dotnet --version
```
Si no está instalado, sigue las instrucciones de la página oficial para instalar la versión adecuada.

### 3. Ejecutar el proyecto
Una vez que hayas clonado el repositorio y tengas .NET instalado, navega a la carpeta del proyecto y ejecuta el siguiente comando:
```
cd ProyectosConMenu
dotnet run
```
Esto compilará y ejecutará el proyecto, mostrándote el menú de opciones en la consola.

### Estructura del Proyecto
Este proyecto tiene la siguiente estructura de carpetas:

```plaintext
ProyectosConMenu
├── Ejercicios
│   ├── AdivinaElNumero.cs       # Juego de adivinar el número
│   ├── AgendaContactos.cs       # Agenda de contactos
│   ├── DiccionarioJuego.cs      # Juego del diccionario
│   ├── GeneradorContrasena.cs  # Generador de contraseñas
│   └── JuegoMemoria.cs         # Juego de memoria
├── Program.cs                   # Entrada principal del programa (menú)
└── ProyectosConMenu.csproj      # Archivo de proyecto .NET
```

### Descripción de los Archivos:
* Ejercicios/: Contiene los archivos de código de cada ejercicio o juego.
* Program.cs: El archivo principal que ejecuta el menú e interactúa con el usuario.
* ProyectosConMenu.csproj: El archivo del proyecto que gestiona las dependencias y la configuración de .NET.

### Uso
Al ejecutar el proyecto con `dotnet run`, verás un menú con las siguientes opciones:
```
1. Agenda de Contactos
2. Generador de Contraseñas
3. Adivina el Número
4. Diccionario Juego
5. Juego de Memoria
0. Salir
```
* Agenda de Contactos: Te permite agregar, mostrar y buscar contactos.
* Generador de Contraseñas: Puedes generar contraseñas con diferentes longitudes y complejidades.
* Adivina el Número: Debes adivinar un número aleatorio generado por el sistema.
* Diccionario Juego: Debes adivinar la definición de una palabra.
* Juego de Memoria: Debes recordar una palabra mostrada brevemente y adivinarla correctamente.
Cada opción está numerada y puedes seleccionar la opción que desees al ingresar el número correspondiente.

### Dependencias
Este proyecto está desarrollado con **.NET 9.0**. Asegúrate de tener instalado el SDK de .NET 9.0 en tu máquina para ejecutar el proyecto.

Puedes descargarlo desde: [https://dotnet.microsoft.com/download/dotnet](URL)

### Contribuciones
Las contribuciones son bienvenidas. Si tienes alguna idea para mejorar el proyecto o alguna corrección, no dudes en hacer un *pull request*.

### Pasos para contribuir:
1. Haz un *fork* de este repositorio.
2. Crea una rama para tus cambios (`git checkout -b feature-nueva-funcionalidad`).
3. Realiza tus cambios y haz un *commit* de ellos (`git commit -am 'Añadir nueva funcionalidad'`).
4. Envía tus cambios al repositorio remoto (`git push origin feature-nueva-funcionalidad`).
5. Abre un *pull request*.

### Licencia
Este proyecto está bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.
```
### Explicación de cada sección:

1. **Descripción del Proyecto**: Aquí describes qué hace el proyecto en términos generales y qué tipo de ejercicios contiene.
2. **Instrucciones de Instalación**: Incluye los pasos para clonar el repositorio y cómo instalar las dependencias necesarias (como .NET SDK) para que el proyecto funcione en una máquina local.
3. **Estructura del Proyecto**: Explica la estructura de carpetas del proyecto, qué contiene cada archivo y cuál es su propósito.
4. **Uso**: Proporciona instrucciones sobre cómo ejecutar el programa y cómo interactuar con el menú de opciones.
5. **Dependencias**: Aquí mencionamos que el proyecto requiere el SDK de .NET 9.0.
6. **Contribuciones**: Proporciona instrucciones sobre cómo otras personas pueden contribuir al proyecto si lo desean.
7. **Licencia**: Generalmente, se coloca una referencia a la licencia del proyecto (si la tienes). Si no la tienes, puedes omitir esta sección o agregarla más tarde.

Este archivo `README.md` proporcionará a cualquier persona que acceda a tu repositorio la información que necesita para entender, instalar y usar tu proyecto de manera efectiva.
```







