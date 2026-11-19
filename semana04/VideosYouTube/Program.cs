using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Como aprender C# do zero", "Canal Programação Fácil", 845);
        video1.AdicionarComentario(new Comentario("Ana", "Explicação muito clara, obrigada!"));
        video1.AdicionarComentario(new Comentario("Bruno", "Finalmente entendi o que é uma classe."));
        video1.AdicionarComentario(new Comentario("Carla", "Poderia fazer um vídeo sobre listas?"));

        Video video2 = new Video("Receita de pão caseiro", "Cozinha da Vó", 620);
        video2.AdicionarComentario(new Comentario("Daniel", "Fiz hoje e ficou ótimo."));
        video2.AdicionarComentario(new Comentario("Eduarda", "Quanto tempo deixo a massa descansar?"));
        video2.AdicionarComentario(new Comentario("Felipe", "Minha avó fazia exatamente assim."));
        video2.AdicionarComentario(new Comentario("Gabriela", "Dá para usar farinha integral?"));

        Video video3 = new Video("Trilha na Chapada Diamantina", "Aventuras pelo Brasil", 1230);
        video3.AdicionarComentario(new Comentario("Henrique", "Que paisagem incrível!"));
        video3.AdicionarComentario(new Comentario("Isabela", "Qual foi a época do ano da viagem?"));
        video3.AdicionarComentario(new Comentario("João", "Já coloquei na minha lista de viagens."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.Exibir();
            Console.WriteLine();
        }
    }
}
