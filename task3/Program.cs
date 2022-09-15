internal class DocumentWorker
{
    public void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

internal class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine(
            "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

internal class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

static class Program
{
    static void Work(DocumentWorker doc)
    {
        var flag = true;
        while (flag)
        {
            Console.WriteLine("0 - открыть документ, 1 - редактировать документ, 2 - сохранить документ, 3 - выход");
            var i = Console.ReadLine();
            switch (i)
            {
                case "0":
                {
                    doc.OpenDocument();
                    break;
                }
                case "1":
                {
                    doc.EditDocument();
                    break;
                }
                case "2":
                {
                    doc.SaveDocument();
                    break;
                }
                default:
                {
                    flag = false;
                    break;
                }
            }
        }
    }
    static void Main()
    {
        const string pro = "123";
        const string ex = "1234";
        
        Console.Write("Введите ключ доступа (если его нет, то нажмите ENTER): ");
        string? key = Console.ReadLine();
        
        switch (key)
        {
            case pro:
            {
                ProDocumentWorker doc = new();
                Work(doc);
                break;
            }
            case ex:
            {
                ExpertDocumentWorker doc = new();
                Work(doc);
                break;
            }
            default:
            {
                DocumentWorker doc = new();
                Work(doc);
                break;
            }
        }
    }
}

