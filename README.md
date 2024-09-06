# Разработка клиент-серверного приложения на C# с использованием TCP/IP сокетов

## Описание проекта

Данный проект представляет собой клиент-серверное приложение, разработанное на языке программирования C# с использованием TCP/IP сокетов. Приложение позволяет клиенту подключаться к серверу, отправлять текстовые сообщения и файлы, а также получать ответы от сервера. Приложение имеет графический интерфейс пользователя (GUI) для удобного взаимодействия.

## Функциональность

- **Сервер:**
  - Ожидает подключения от клиентов на заданном порту.
  - Принимает текстовые сообщения и файлы от клиента.
  - Отправляет подтверждения получения сообщений и файлов обратно клиенту.

- **Клиент:**
  - Подключается к серверу.
  - Отправляет текстовые сообщения и файлы на сервер.
  - Получает подтверждения и сообщения от сервера.
  - Обеспечивает графический интерфейс для удобства пользователя.

## Установка

1. **Клонирование репозитория:**
    ```bash
    git clone https://github.com/Sq1la/application.git
    cd your-repository
    ```

2. **Настройка серверной части:**
    - Откройте проект `Server` в Visual Studio.
    - Соберите и запустите проект, чтобы запустить сервер.

3. **Настройка клиентской части:**
    - Откройте проект `TcpClientGui` в Visual Studio.
    - Проверьте, что IP-адрес и порт сервера установлены правильно в коде клиента.
    - Соберите и запустите проект, чтобы запустить клиентское приложение.

## Использование

1. **Запуск сервера:**
    - Запустите проект `Server`.
    - Сервер начнет прослушивание на порту 8888 (или другом, если изменили).

2. **Запуск клиента:**
    - Запустите проект `TcpClientGui`.
    - Введите IP-адрес и порт сервера, если требуется.
    - Нажмите кнопку "Подключить" для установления соединения с сервером.
    - Используйте кнопки "Отправить" и "Отправить файл" для отправки данных на сервер.
    - Посмотрите ответы от сервера и историю сообщений в графическом интерфейсе клиента.

## Обработка ошибок

Ошибки обрабатываются с помощью блока `try-catch`, и сообщения об ошибках записываются в файл журнала (`error_log.txt`). Это позволяет отслеживать и анализировать проблемы, возникающие в процессе работы приложения.

## Будущие улучшения

- Расширение функциональности клиента и сервера.
- Добавление функций для фильтрации и сортировки задач.
- Интеграция с другими сервисами и системами напоминаний.
- Улучшение пользовательского интерфейса.

