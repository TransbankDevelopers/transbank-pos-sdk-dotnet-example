# Proyecto de ejemplo de Integración del SDK .NET para POS Integrados

## Requerimientos

Para poder ejecutar el proyecto de ejemplo necesitas tener instalada las siguientes herramientas
en tu computador:

1. git ([como instalar git][git_install])
2. Visual Studio ([instalar VisualStudio 2017][visualstudio_install])
3. Asegúrate de tener instaladas las dependencias del SDK
   1. Libserialport.
   2. TransbankWraper.
4. Los drivers necesarios para utilizar tu Puerto Serial o adaptador USB-Serial.

[git_install]: https://git-scm.com/book/en/v2/Getting-Started-Installing-Git
[visualstudio_install]: https://visualstudio.microsoft.com/es/downloads/

Recuerda que también necesitas tener conectado un POS Integrado.

## Clonar repositorio

Primero deberás clonar este repositorio en tu computador:

````batch
git clone https://github.com/TransbankDevelopers/transbank-pos-sdk-dotnet-example.git
````

## Ejecutar ejemplo

El ejemplo viene listo para correr usando Visual Studio:

1. Abrir la solución `TransbankPosSDKExample.sln` con Visual Studio
2. Hacer clic derecho sobre el proyecto `TransbankPosSDKFormExample`.
3. Seleccionar la opción Establecer como proyecto de inicio.
4. Clic derecho nuevamente sobre el proyecto `TransbankPosSDKFormExample` y seleccionar la opción Compilar.
5. Iniciar la aplicación (`ctrl + F5`) `Menú` -> `Debug` -> `Iniciar sin debug`

Si todo ha salido bien deberías ver una aplicación WindowsForm y probar los distintos comandos del POS que tengas conectado a tu equipo.