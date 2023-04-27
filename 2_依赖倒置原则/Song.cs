using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern._2_依赖倒置原则.usePattern
{
    //高层模块不应该依赖于低层模块，模块应该依赖于抽象

    public class Singer
    {
        public void SingSong(ISongWords songWords)
        {
            Console.WriteLine("歌手正在唱" + songWords.GetSongWords());
        }

    }

    public interface ISongWords
    {
        string GetSongWords();
    }

    public class ChineseSong : ISongWords
    {
        public string GetSongWords()
        {
            return "汉语歌曲";
        }
    }

    public class EnglishSong : ISongWords
    {
        public string GetSongWords()
        {
            return "英文歌曲";
        }
    }

}
