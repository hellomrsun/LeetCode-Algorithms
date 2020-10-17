--solution 1:
SELECT name, population, area
FROM World
WHERE population > 25000000 or area > 3000000



--solution 2:
SELECT name, population, area
FROM World
WHERE population > 25000000 

UNION

SELECT name, population, area
FROM World
WHERE area > 3000000
