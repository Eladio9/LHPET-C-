namespace LHPet.Models;

public class Fornecedor;

{
    public int Id { get; set; }
public string Nome { get; set; }
public string Cnpj { get; set; }
public string Email { get; set; }
public Fornecedor(int id, string nome, string cnpj, string email)
{
    this.Id = id;
    this.Nome = nome;
    this.Cnpj = cnpj;
    this.Email = email;

    ViewBag.listaFornecedores = listaFornecedores;
    return View();

}

Fornecedor fornecedor1 = new Fornecedor(01, "C#
PET S / A", "14.182.102 / 0001 - 80", "c - sharp@pet.org");
Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl
Alt Dog", "15.836.698 / 0001 - 57", "ctrl@alt.dog.br");
Fornecedor fornecedor3 = new Fornecedor(03,
"BootsPet INC", "40.810.224/0001-83",
"boots.pet@gatomania.us");
Fornecedor fornecedor4 = new Fornecedor(04, "Tik
Tok Dogs", "87.945.350 / 0001 - 09",
"noisnamidia@tiktokdogs.uk");
Fornecedor fornecedor5 = new Fornecedor(05,
"Bifinho Forever", "18.760.614/0001-37",
"contato@bff.us");
}