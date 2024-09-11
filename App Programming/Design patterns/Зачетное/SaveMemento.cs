using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зачетное
{
    public interface IMemento
    {
        string GetState();
    }

    public class SaveMemento : IMemento
    {
        private string _state;

        public SaveMemento(string state)
        {
            this._state = state;
        }
        // Создатель использует этот метод, когда восстанавливает своё
        // состояние.
        public string GetState()
        {
            return this._state;
        }


        public bool IsRect()
        {
            return _state.Contains("Rect");
        }
        public bool IsElips()
        {
            return _state.Contains("Elips");
        }
        public bool IsTrack()
        {
            return _state.Contains("Tracks");
        }


    }

    public class  Saver
    {
        private List<IMemento> _mementos = new List<IMemento>();
        List<Things> All_Things = new List<Things>();

        public Saver(List<Things> things)
        {
            All_Things = things;
        }
        public void Save ()
        {
            StreamWriter save_file = new StreamWriter("saves.txt");

            foreach (var item in All_Things)
            {
                IMemento memento = new SaveMemento(null);
                if (item is Rect)
                {
                    memento = ((Rect)item).Save();

                }
                else if (item is Elips)
                {
                    memento = ((Elips)item).Save();
                }
                else if (item is Tracks)
                {
                    memento = ((Tracks)item).Save();
                }
                save_file.WriteLine(memento.GetState());
            }
            save_file.Close();
        }
        
        public void Load()
        {
            string[] lines = File.ReadAllLines("saves.txt");
            foreach (string s in lines)
            {
               
                SaveMemento memento = new SaveMemento(s);
                

                if (memento.IsRect())
                {
                    Rect input = new Rect(0, 0, 0, 0, Color.Black);
                    input.Load(memento);
                    All_Things.Add(input);

                }
                if (memento.IsElips())
                {
                    Elips input = new Elips(0, 0, 0, 0, Color.Black);
                    input.Load(memento);
                    All_Things.Add(input);
                }
                if (memento.IsTrack())
                {
                    Tracks input = new Tracks(0, 0, 0, 0, Color.Black);
                    input.Load(memento);
                    All_Things.Add(input);
                }



            }
        }
        public List<Things> return_load()
        {
            return All_Things;
        }
    }
}
