SELECT S.STUDENT_NAME , D.DEPARTMENT_NAME 
FROM DEPARTMENT D , STUDENT S
WHERE S.DEPARTMENT_ID = D.DEPARTMENT_ID AND CITY="Coimbatore"
order BY STUDENT_NAME