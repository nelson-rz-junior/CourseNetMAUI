namespace AppMauiGallery.Views.Lists.Models;

public class Movie
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public TimeSpan Duration { get; set; }

    public short LaunchYear { get; set; }

    public override string ToString()
    {
        return $"[ {Id} ]: {Name} ({LaunchYear})";
    }
}

public class GroupMovie : List<Movie>
{
    public string CompanyName { get; set; }
}

public class MovieList
{
    public static List<GroupMovie> GetGroupList()
    {
        var disneyGroup = new GroupMovie() { CompanyName = "Disney" };
        disneyGroup.Add(new Movie()
        {
            Id = 1,
            Name = "Emancipation",
            Description = "Emancipation é um longa-metragem thriller de ação e drama histórico estadunidense dirigido por Antonie Fuqua, escrito por Willian N.Collage, estrelado por Will Smith lançado em 2022 acerca de um homem.",
            LaunchYear = 2022,
            Duration = new TimeSpan(2, 12, 0)
        });

        disneyGroup.Add(new Movie()
        {
            Id = 2,
            Name = "Tudo em Todo o Lugar ao Mesmo Tempo",
            Description = "Uma ruptura interdimensional bagunça a realidade e uma inesperada heroína precisa usar seus novos poderes para lutar contra os perigos bizarros do multiverso.",
            LaunchYear = 2022,
            Duration = new TimeSpan(2, 19, 0)
        });

        disneyGroup.Add(new Movie()
        {
            Id = 3,
            Name = "Patrulha Canina: Um Filme Superpoderoso",
            Description = "Os filhotes da Patrulha Canina ganham poderes após um meteoro mágico cair na cidade. Para um deles, é um grande sonho que se tornou realidade, mas a felicidade dos patrulheiros pode estar ameaçada quando o maior inimigo dos filhotes foge da prisão.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 33, 0)
        });

        var paramountGroup = new GroupMovie() { CompanyName = "Paramount" };
        paramountGroup.Add(new Movie()
        {
            Id = 4,
            Name = "Super Mario Bros. O Filme",
            Description = "Mario e seu irmão Luigi são encanadores do Brooklyn, em Nova York. Um dia, eles vão parar no reino dos cogumelos, governado pela Princesa Peach. O local é ameaçado por Bowser, rei dos Koopas, que faz de tudo para conseguir reinar em todos os lugares.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 32, 0)
        });

        paramountGroup.Add(new Movie()
        {
            Id = 5,
            Name = "Irmãos de Honra",
            Description = "A história de Jesse Brown, o primeiro aviador negro na história da Marinha, e seu colega piloto de caça Tom Hudner. Ajudando a virar a maré na batalha mais brutal da Guerra da Coreia, seus sacrifícios heroicos os tornam os alas mais importantes.",
            LaunchYear = 2022,
            Duration = new TimeSpan(2, 19, 0)
        });

        paramountGroup.Add(new Movie()
        {
            Id = 6,
            Name = "Gatos no Museu",
            Description = "Em uma de suas aventuras, o gato Vincent acaba indo parar em um museu do outro lado do mundo. Acompanhado de seu fiel amigo, o ratinho Maurice, ele conhece um esquadrão de gatos dedicados a proteger as valiosas obras de arte contra roedores e outras ameaças.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 23, 0)
        });

        paramountGroup.Add(new Movie()
        {
            Id = 7,
            Name = "Missão Cegonha 2",
            Description = "O valente pardal Richard retorna em uma emocionante jornada para resgatar seus amigos que foram aprisionados por um pavão. Para se libertarem, eles resolvem um enigma e descobrem a Grande Joia, usando trabalho em equipe e habilidades de cegonha.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 25, 0)
        });

        var universalGroup = new GroupMovie() { CompanyName = "Universal" };
        universalGroup.Add(new Movie()
        {
            Id = 8,
            Name = "Casamento Armado",
            Description = "Shotgun Wedding é um futuro filme de comédia romântica estadunidense dirigido por Jason Moore com roteiro de Mark Hammer e Liz Meriwether. O filme é estrelado por Josh Duhamel e Jennifer Lopez e será distribuído pela Lionsgate Films.",
            LaunchYear = 2022,
            Duration = new TimeSpan(1, 40, 0)
        });

        universalGroup.Add(new Movie()
        {
            Id = 9,
            Name = "Leonardo, O Inventor",
            Description = "Incansavelmente curioso e teimoso inventor Leonardo da Vinci inventa engenhocas voadoras e máquinas inovadoras, estuda o corpo humano, e com a ajuda da audaciosa Princesa da França Marguerite para tentar achar o sentido da vida.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 37, 0)
        });

        universalGroup.Add(new Movie()
        {
            Id = 10,
            Name = "Juba - Uma Aventura no Ártico",
            Description = "Vivendo no Parque Nacional do Fiorde de Saguenay, Katak é uma baleia beluga jovem que ainda não adquiriu a coloração branca típica de sua espécie na idade adulta.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 22, 0)
        });

        List<GroupMovie> list = new()
        {
            disneyGroup,
            paramountGroup,
            universalGroup
        };

        return list;
    }

    public static List<Movie> GetList()
    {
        List<Movie> list = new();

        list.Add(new Movie()
        {
            Id = 1,
            Name = "Emancipation",
            Description = "Emancipation é um longa-metragem thriller de ação e drama histórico estadunidense dirigido por Antonie Fuqua, escrito por Willian N.Collage, estrelado por Will Smith lançado em 2022 acerca de um homem.",
            LaunchYear = 2022,
            Duration = new TimeSpan(2, 12, 0)
        });

        list.Add(new Movie()
        {
            Id = 2,
            Name = "Tudo em Todo o Lugar ao Mesmo Tempo",
            Description = "Uma ruptura interdimensional bagunça a realidade e uma inesperada heroína precisa usar seus novos poderes para lutar contra os perigos bizarros do multiverso.",
            LaunchYear = 2022,
            Duration = new TimeSpan(2, 19, 0)
        });

        list.Add(new Movie()
        {
            Id = 3,
            Name = "Patrulha Canina: Um Filme Superpoderoso",
            Description = "Os filhotes da Patrulha Canina ganham poderes após um meteoro mágico cair na cidade. Para um deles, é um grande sonho que se tornou realidade, mas a felicidade dos patrulheiros pode estar ameaçada quando o maior inimigo dos filhotes foge da prisão.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 33, 0)
        });

        list.Add(new Movie()
        {
            Id = 4,
            Name = "Super Mario Bros. O Filme",
            Description = "Mario e seu irmão Luigi são encanadores do Brooklyn, em Nova York. Um dia, eles vão parar no reino dos cogumelos, governado pela Princesa Peach. O local é ameaçado por Bowser, rei dos Koopas, que faz de tudo para conseguir reinar em todos os lugares.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 32, 0)
        });

        list.Add(new Movie()
        {
            Id = 5,
            Name = "Irmãos de Honra",
            Description = "A história de Jesse Brown, o primeiro aviador negro na história da Marinha, e seu colega piloto de caça Tom Hudner. Ajudando a virar a maré na batalha mais brutal da Guerra da Coreia, seus sacrifícios heroicos os tornam os alas mais importantes.",
            LaunchYear = 2022,
            Duration = new TimeSpan(2, 19, 0)
        });

        list.Add(new Movie()
        {
            Id = 6,
            Name = "Gatos no Museu",
            Description = "Em uma de suas aventuras, o gato Vincent acaba indo parar em um museu do outro lado do mundo. Acompanhado de seu fiel amigo, o ratinho Maurice, ele conhece um esquadrão de gatos dedicados a proteger as valiosas obras de arte contra roedores e outras ameaças.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 23, 0)
        });

        list.Add(new Movie()
        {
            Id = 7,
            Name = "Missão Cegonha 2",
            Description = "O valente pardal Richard retorna em uma emocionante jornada para resgatar seus amigos que foram aprisionados por um pavão. Para se libertarem, eles resolvem um enigma e descobrem a Grande Joia, usando trabalho em equipe e habilidades de cegonha.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 25, 0)
        });

        list.Add(new Movie()
        {
            Id = 8,
            Name = "Casamento Armado",
            Description = "Shotgun Wedding é um futuro filme de comédia romântica estadunidense dirigido por Jason Moore com roteiro de Mark Hammer e Liz Meriwether. O filme é estrelado por Josh Duhamel e Jennifer Lopez e será distribuído pela Lionsgate Films.",
            LaunchYear = 2022,
            Duration = new TimeSpan(1, 40, 0)
        });

        list.Add(new Movie()
        {
            Id = 9,
            Name = "Leonardo, O Inventor",
            Description = "Incansavelmente curioso e teimoso inventor Leonardo da Vinci inventa engenhocas voadoras e máquinas inovadoras, estuda o corpo humano, e com a ajuda da audaciosa Princesa da França Marguerite para tentar achar o sentido da vida.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 37, 0)
        });

        list.Add(new Movie()
        {
            Id = 10,
            Name = "Juba - Uma Aventura no Ártico",
            Description = "Vivendo no Parque Nacional do Fiorde de Saguenay, Katak é uma baleia beluga jovem que ainda não adquiriu a coloração branca típica de sua espécie na idade adulta.",
            LaunchYear = 2023,
            Duration = new TimeSpan(1, 22, 0)
        });

        return list;
    }
}
