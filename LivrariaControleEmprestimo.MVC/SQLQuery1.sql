ALTER VIEW VW_Livro_Cliente_Emprestimo
AS
select c.cliCPF, C.cliNome, L.livroNome, LCE.* from Livro_Cliente_Emprestimo LCE
inner join Cliente C on C.Id = LCE.LceIdCliente
inner join Livro L on L.Id = LCE.LceIdLivro