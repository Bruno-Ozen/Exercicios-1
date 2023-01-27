using System;
using static System.Console;

//ALUNO: BRUNO HENRIQUE DE PINHO

public class SistemaCadastro
{
    public List<string> nome = new List<string>();
    public List<string> celular = new List<string>();
    public List<string> cidade = new List<string>();

    public List<string> Nome
    {
        get
        {
            return this.nome;
        }
        set
        {
            this.nome = value;
        }
    }
    public List<string> Celular
    {
        get
        {
            return this.celular;
        }
        set
        { 
            this.celular = value;
        }
    }
    public List<string> Cidade
    {
        get { 
            return this.cidade;
        }
        set { 
            this.cidade = value;
        }
    }

    public void printMenu(string[] opcoes)
    {
        foreach (string opcao in opcoes)
        {
            WriteLine(opcao);
        }

    }

    public static void Main(string[] args)
    {
        int opcao;
        SistemaCadastro sistema = new SistemaCadastro();
        string[] opcoes = {"[1] - Cadastrar fornecedor;",
                           "[2] - Editar fornecedor;" ,
                           "[3] - Excluir fornecedor" ,
                           "[4] - Listar fornecedor;" ,
                           "[5] - Sair."};
        while (true)
        {
            Clear();
            WriteLine("--- SISTEMA DE CADASTRO DE FORNECEDORES ---");
            sistema.printMenu(opcoes);
            try
            {
                opcao = Convert.ToInt32(ReadLine());
            }
            catch (System.FormatException)
            {
                WriteLine("Por favor, digite uma opção entre 1 e " + opcoes.Length);
                continue;
            }
            catch (Exception)
            {
                WriteLine("Um erro aconteceu, tente novamente!!");
                continue;
            }
            switch (opcao)
            {
                case 1:
                    sistema.Cadastrar();
                    break;
                case 2:
                    sistema.Editar();
                    break;
                case 3:
                    sistema.Excluir();
                    break;
                case 4:
                    sistema.Listar();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
    }
    void Cadastrar()
    {
        Clear();
        WriteLine("--- CADASTRANDO UM FORNECEDOR ---");
        WriteLine("Qual é o nome do fornecedor? ");
        this.Nome.Add(ReadLine());
        WriteLine("Qual é o celular do fornecedor? ");
        this.Celular.Add(ReadLine());
        WriteLine("Qual é a cidade do fornecedor? ");
        this.Cidade.Add(ReadLine());
    }

    void Editar()
    {
        int index;
        Clear();
        WriteLine("--- EDITANDO UM FORNECEDOR ---");
        WriteLine("Qual é o nome do fornecedor que deseja editar? ");
        index = this.Nome.IndexOf(ReadLine());
        WriteLine();
        if (index >= 0)
        {
            WriteLine("--- FORNECEDOR QUE SERÁ EDITADO ---");
            WriteLine("Nome do fornecedor: " + Nome[index]);
            WriteLine("Celular do fornecedor: " + Celular[index]);
            WriteLine("Cidade do fornecedor: " + Cidade[index]);
            WriteLine();
            WriteLine("Digite o novo nome do fornecedor: ");
            this.Nome[index] = ReadLine();
            WriteLine("Digite o novo celular do fornecedor: ");
            this.Celular[index] = ReadLine();
            WriteLine("Digite a nova cidade do fornecedor: ");
            this.Cidade[index] = ReadLine();
        }
        else
        {
            WriteLine("Registro não encontrado!!");
            ReadLine();
        }
    }

    void Excluir()
    {
        int index;
        Clear();
        WriteLine("--- EXCLUIR CADASTROS ---");
        WriteLine("Qual é o nome do fornecedor que deseja deletar? ");
        index = this.Nome.IndexOf(ReadLine());
        WriteLine();
        if (index >= 0)
        {
            WriteLine("--- FORNECEDOR QUE SERÁ DELETADO ---");
            WriteLine("Nome do fornecedor: " + Nome[index]);
            WriteLine("Celular do fornecedor: " + Celular[index]);
            WriteLine("Cidade do fornecedor: " + Cidade[index]);
            Nome.RemoveAt(index);
            Celular.RemoveAt(index);
            Cidade.RemoveAt(index);
        }
        else
        {
            WriteLine("Registro não encontrado!!");
            ReadLine();
        }
        ReadLine();
    }

    void Listar()
    {
        Clear();
        WriteLine("--- LISTANDO FORNECEDORES ---");
        for (int i = 0; i < Nome.Count; i++)
        {
            WriteLine("--- FORNECEDOR " + (i + 1) + "---");
            WriteLine("Nome: " + Nome[i]);
            WriteLine("Celular: " + Celular[i]); ;
            WriteLine("Cidade: " + Cidade[i]);
            WriteLine();
        }
        ReadLine();
    }

    /*public string Nome
    {
        get { return this.nome[index]; }
        set { this.nome[index] = value; }
    }

    public string this[int index]
    {
        get { return this.celular[index]; }
        set { this.celular[index] = value; }
    }

    public string this[int index]{
        get { return this.cidade[index]; }
        set { this.cidade[index]= value; }
    }*/
}