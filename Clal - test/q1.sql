SELECT TOP 30
    c.ID AS CustomerID,
    c.IdentityNo,
    c.FullName,
    COUNT(CASE WHEN pd.StateCode = 4 THEN 1 ELSE NULL END) AS ActiveCoverageCount,
    SUM(pd.InsuranceAmt) AS TotalInsuranceAmount
FROM
    CRM.Customer c
JOIN
    CRM.PolicyDetails pd ON c.ID = pd.CustomerId
GROUP BY
    c.ID, c.IdentityNo, c.FullName
HAVING
    COUNT(CASE WHEN pd.StateCode = 4 THEN 1 ELSE NULL END) > 4
    AND SUM(pd.InsuranceAmt) > 2000
ORDER BY
    TotalInsuranceAmount DESC;
