using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Annotations_And_Garbage_Collection
{
    public class DisposableResourceHolder : IDisposable
    {
        private SafeHandle resource;
        public DisposableResourceHolder()
        {
            this.resource = resource;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.resource != null)
                {
                    this.resource.Dispose();
                }
            }
        }
    }
    public class Garbage_Collection
    {
        public void Collector()
        {
            long memory1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[50000];
                values = null;
            }
            long memory2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long memory3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(memory1);
                Console.WriteLine(memory2);
                Console.WriteLine(memory3);
            }
        }
    }
}
