SELECT NAME, CONCAT(SUBSTRING(NAME,1,3), SUBSTRING(PHNO,1,3)) AS PASSWORD
FROM USERS
order BY NAME