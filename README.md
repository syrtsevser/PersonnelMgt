# PersonnelMgt
ИС "Сотрудники компании" занимается управлением проектной деятельностью IT-компании.

Выполнено на C# в среде VS2019, на платформе .NET 4.7.2, по технологии WinForms. В качестве СУБД использует PostgreSQL.

Используемые модули: npgsql, fody.

## Установка
Запустить PgAdmin4, импортировать БД из файла [\db\db.sql](...).
Также имеется файл с примером пользователя user1 в файле [\db\all_roles_and_users.sql](...)

При создании новых пользователей, им необходимо выдать следующие права:
```
REVOKE connect ON DATABASE personnel_mgt FROM PUBLIC;
GRANT CONNECT ON DATABASE personnel_mgt TO new_user;
GRANT ALL PRIVILEGES ON DATABASE personnel_mgt to new_user;
```

## Использование
Запустить сервер Postgre и исполняемый файл приложения.

Использовать пользователя БД при авторизации (например, postgre или иной). В окне "Параметры" можно также изменить адрес сервера и наименование БД.
