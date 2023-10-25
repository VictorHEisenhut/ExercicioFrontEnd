use permissions;

select * from mysql.user;

show databases;

create user dba@localhost identified by 'dba123';

grant create 
on vendas.*
to dba@localhost;

show grants for root@localhost;
show grants for dba@localhost;
