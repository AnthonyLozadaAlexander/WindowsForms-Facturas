# Instrucciones para GitHub Copilot

## Idioma
- Siempre escribe los mensajes de commit en **español**.
- Siempre responde en **español** cuando te hagan preguntas en el chat.

## Formato de commits
Usa el formato convencional:

```
tipo(alcance): descripción breve en español
```

### Tipos permitidos
| Tipo | Uso |
|---|---|
| `feat` | Nueva funcionalidad |
| `fix` | Corrección de un bug |
| `refactor` | Reestructuración de código sin cambiar funcionalidad |
| `style` | Cambios de formato, espaciado, nombres |
| `docs` | Cambios en documentación o comentarios |
| `chore` | Tareas de mantenimiento (configuración, dependencias) |
| `test` | Añadir o modificar pruebas |

### Ejemplos de mensajes correctos
```
feat(formulario): agregar validación de número de mesa
fix(btnRegistrar): corregir sincronización de listas paralelas
refactor(validarMesa): simplificar lógica de retorno
style(Form1): mejorar espaciado y nombres de variables
docs(Form1): agregar comentarios a funciones auxiliares
```

## Reglas adicionales
- La descripción debe ser **clara, corta y en infinitivo** (agregar, corregir, eliminar...).
- No uses puntos al final de la descripción.
- El alcance (entre paréntesis) debe indicar el módulo o archivo afectado.
- Si el cambio afecta múltiples archivos, omite el alcance: `feat: descripción`.
