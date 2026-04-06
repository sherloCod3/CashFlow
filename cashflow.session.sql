SELECT
	*
FROM
	cashflowdb.expenses
;


DELETE FROM cashflowdb.expenses
WHERE
	Id = 2
;


UPDATE cashflowdb.expenses
SET
	Description = "gift for my birthday",
	Amount = 1200.99
WHERE
	Id = 1
;