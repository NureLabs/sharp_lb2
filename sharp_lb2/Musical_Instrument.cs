using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_lb2
{
    class Musical_Instrument : Recording_Room
    {
        private int instrument_id;
        private Instrument_Type instrument_type;
        private double instrument_price;

        /*public Musical_Instrument()
        {
            instrument_id = got_id;
            instrument_type = got_type;
            instrument_price = got_price;

            Array.Resize(ref instrument_ids, instrument_ids.Length + 1);
            instrument_ids[instrument_ids.Length - 1] = instrument_ids.Last() + 1;

            real_amount_of_instruments += 1;
        }*/
        public Musical_Instrument(int got_id, Instrument_Type got_type, double got_price)
        {
            instrument_id = got_id;
            instrument_type = got_type;
            instrument_price = got_price;

            Array.Resize(ref instrument_ids, instrument_ids.Length + 1);
            instrument_ids[instrument_ids.Length - 1] = got_id;

            amount_of_musical_instruments_in_studio += 1;
        }
    }
}
