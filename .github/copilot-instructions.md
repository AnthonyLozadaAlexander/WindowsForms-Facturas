# Instrucciones de GitHub Copilot para Commits

Al generar mensajes de commit, por favor sigue la especificación de [Conventional Commits](https://www.conventionalcommits.org/).

## Formato
```
<tipo>[ámbito opcional]: <descripción>

[cuerpo opcional]

[nota(s) al pie opcional(es)]
```

## Tipos
* **feat**: Una nueva característica
* **fix**: Una corrección de un error
* **docs**: Cambios únicamente en la documentación
* **style**: Cambios que no afectan el significado del código (espacios en blanco, formato, punto y coma faltante, etc.)
* **refactor**: Un cambio en el código que no corrige un error ni añade una característica
* **perf**: Un cambio en el código que mejora el rendimiento
* **test**: Añadir pruebas faltantes o corregir pruebas existentes
* **build**: Cambios que afectan el sistema de compilación o dependencias externas
* **ci**: Cambios en nuestros archivos y scripts de configuración de CI
* **chore**: Otros cambios que no modifican los archivos fuente ni los de pruebas
* **revert**: Revierte un commit anterior

## Reglas
1. La descripción debe estar escrita en modo imperativo ("añadir", no "añadido" ni "añade").
2. No se debe capitalizar (poner en mayúscula) la primera letra de la descripción.
3. No debe haber un punto (.) al final de la descripción.
4. Mantén la primera línea por debajo de los 72 caracteres.
5. Si hay un cuerpo, este debe estar separado de la descripción por una línea en blanco y proporcionar más detalles sobre los cambios.
