Что изменено по TODO:
1. Groups показывает название направления через Include(Direction), а не direction id.
2. Students показывает название группы и направление группы, а не group id.
3. Groups: добавлен фильтр по направлению.
4. Students: добавлен фильтр по направлению и по группе.
5. Groups: добавление/изменение группы с выбором направления через выпадающий список.
6. Groups: добавление/изменение учебных дней через галочки.
7. Groups Index показывает учебные дни словами: Пн., Ср., Пт.
8. Disciplines Details показывает список преподавателей, которые могут вести дисциплину.
9. Teachers Details показывает список дисциплин, которые может вести преподаватель.

ВАЖНО ПО БАЗЕ:
Перед запуском проекта выполни скрипт UpdateDatabase.sql в SQL Server Management Studio для базы PD_321.
Он добавляет в таблицу Groups поля monday, tuesday, wednesday, thursday, friday, saturday, sunday.
Без этого Groups не откроется, потому что проект будет ждать эти поля в базе.

Подключение осталось старое:
Server=.\SQLEXPRESS;Database=PD_321;Trusted_Connection=True;TrustServerCertificate=True;
