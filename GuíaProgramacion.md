# Guía de Programación

## Console.Write y Console.WriteLine

### `Console Write` para el texto que no lleva espacio y `Console.WriteLine` para los que si (salto de línea).

```csharp         
Console.Write("hola");
Console.Write(" ");
Console.Write("fabito!");
```

## Secuencias de Escape

### `\n` Salto de Línea: Agrega un Enter al Texto
### `\t` Tabulación: Alinea bloques de texto en columnas
### `\"` Comillas Dobles: Si se quiere insertar unas, es necesario agregar la diagonal
### `\\` Barra Invertida: Es el imicio de todas las secuencias, se utiliza para escapar, quedando como `\\` cuando se quiere mostrar.

## Agregando colores
### La consola utiliza colores por defecto, por lo general:

#### Fondo: Negro

#### Texto: Blanco

### Es posible configurar la consola utilizando los siguientes métodos:

### `Console.ForegroundColor`: Permite asignar un color al texto

### `Console.BackgroundColor`: Permite asignar un color al fondo

### Es importante regresar los colores a los valores por defecto al terminar:

### `Console.ResetColor()`: Regresa los colores a valores por defecto