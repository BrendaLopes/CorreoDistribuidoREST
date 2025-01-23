# Sistema Distribuido para Envío de Correos Electrónicos

Este proyecto implementa un **sistema distribuido** utilizando **ASP.NET Core Web API** y **Windows Forms**. La funcionalidad principal es permitir la creación y envío de correos electrónicos almacenados en el sistema de archivos.

## Descripción del Proyecto

El sistema se divide en dos componentes principales:

### 1. **Servidor (CorreoApiServer)**

- **Tecnología:** ASP.NET Core Web API.
- **Funcionalidad:**
  - Provee un endpoint REST para crear correos.
  - Almacena los correos como archivos JSON en un directorio específico.
  - Monitorea el directorio de correos pendientes y envía los correos utilizando una tarea automatizada.
  - Una vez enviado, el correo se mueve al directorio de procesados.

### 2. **Cliente (CorreoCliente)**

- **Tecnología:** Windows Forms.
- **Funcionalidad:**
  - Permite crear correos mediante una interfaz gráfica de usuario.
  - Envia la información del correo al servidor utilizando el API REST.

---

## Características del Proyecto

- **Cliente Windows Forms:**
  - Interfaz para introducir el destinatario, asunto, mensaje y fecha de creación.
  - Validación de campos obligatorios.
  - Conexión con el servidor a través de HTTP.

- **Servidor Web API:**
  - Endpoint REST para aceptar solicitudes de creación de correos.
  - Uso de directorios locales para almacenar correos pendientes y procesados.
  - Servicio automatizado para procesar los correos pendientes cada 10 segundos.
  - Simulación de envío de correos.

---

## Requisitos del Sistema

- **.NET SDK 8.0 o superior.**
- **Visual Studio 2022** o **Visual Studio Code**.
- **Windows OS** para soporte de Windows Forms.

---

## Estructura del Proyecto

```plaintext
/CorreoDistribuido/
├── CorreoApiServer/         # Proyecto del servidor (API REST)
├── CorreoCliente/           # Proyecto del cliente (Windows Forms)
└── CorreoDistribuido.sln    # Solución que integra ambos proyectos
