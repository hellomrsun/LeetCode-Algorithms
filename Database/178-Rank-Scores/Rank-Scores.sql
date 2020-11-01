--CREATE TABLE Scores (Id INT, Score decimal(10, 2));

--INSERT Scores(Id, Score) VALUES(1, 3.50);
--INSERT Scores(Id, Score) VALUES(2, 3.65);
--INSERT Scores(Id, Score) VALUES(3, 4.00);
--INSERT Scores(Id, Score) VALUES(4, 3.85);
--INSERT Scores(Id, Score) VALUES(5, 4.00);
--INSERT Scores(Id, Score) VALUES(6, 3.65);


SELECT Score, dense_rank() over( order by score desc) as Rank
FROM Scores


--See more: Dense_rank(), Rank() etc  https://www.cnblogs.com/52XF/p/4209211.html


