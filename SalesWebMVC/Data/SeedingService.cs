using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Departament.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }

            Departament d1 = new Departament() { Name = "computadores" };
            Departament d2 = new Departament() { Name = "Eletrônicos" };
            Departament d3 = new Departament() { Name = "Moda" } ;
            Departament d4 = new Departament() { Name = "Livros" };

            Seller s1 = new Seller("Diogo Salvador", "diogo@gmail.com", new DateTime(1993, 09, 13), 2200.00, d1);
            Seller s2 = new Seller("Ana Maria", "ana@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller("Alex Pereira", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller("Martha Carvalho", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller("Max Willian", "max@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller("Alex Santos", "alexsantos@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(new DateTime(2020, 09, 25), 11000.0, SalesStatus.Faturado, s1);
            SalesRecord r2 = new SalesRecord(new DateTime(2020, 09, 4), 7000.0, SalesStatus.Faturado, s5);
            SalesRecord r3 = new SalesRecord(new DateTime(2020, 09, 13), 4000.0, SalesStatus.Cancelado, s4);
            SalesRecord r4 = new SalesRecord(new DateTime(2020, 09, 1), 8000.0, SalesStatus.Faturado, s1);
            SalesRecord r5 = new SalesRecord(new DateTime(2020, 09, 21), 3000.0, SalesStatus.Faturado, s3);
            SalesRecord r6 = new SalesRecord(new DateTime(2020, 09, 15), 2000.0, SalesStatus.Faturado, s1);
            SalesRecord r7 = new SalesRecord(new DateTime(2020, 09, 28), 13000.0, SalesStatus.Faturado, s2);
            SalesRecord r8 = new SalesRecord(new DateTime(2020, 09, 11), 4000.0, SalesStatus.Faturado, s4);
            SalesRecord r9 = new SalesRecord(new DateTime(2020, 09, 14), 11000.0, SalesStatus.Pendente, s6);
            SalesRecord r10 = new SalesRecord(new DateTime(2020, 09, 7), 9000.0, SalesStatus.Faturado, s6);
            SalesRecord r11 = new SalesRecord(new DateTime(2020, 09, 13), 6000.0, SalesStatus.Faturado, s2);
            SalesRecord r12 = new SalesRecord(new DateTime(2020, 09, 25), 7000.0, SalesStatus.Pendente, s3);
            SalesRecord r13 = new SalesRecord(new DateTime(2020, 09, 29), 10000.0, SalesStatus.Faturado, s4);
            SalesRecord r14 = new SalesRecord(new DateTime(2020, 09, 4), 3000.0, SalesStatus.Faturado, s5);
            SalesRecord r15 = new SalesRecord(new DateTime(2020, 09, 12), 4000.0, SalesStatus.Faturado, s1);
            SalesRecord r16 = new SalesRecord(new DateTime(2020, 10, 5), 2000.0, SalesStatus.Faturado, s4);
            SalesRecord r17 = new SalesRecord(new DateTime(2020, 10, 1), 12000.0, SalesStatus.Faturado, s1);
            SalesRecord r18 = new SalesRecord(new DateTime(2020, 10, 24), 6000.0, SalesStatus.Faturado, s3);
            SalesRecord r19 = new SalesRecord(new DateTime(2020, 10, 22), 8000.0, SalesStatus.Faturado, s5);
            SalesRecord r20 = new SalesRecord(new DateTime(2020, 10, 15), 8000.0, SalesStatus.Faturado, s6);
            SalesRecord r21 = new SalesRecord(new DateTime(2020, 10, 17), 9000.0, SalesStatus.Faturado, s2);
            SalesRecord r22 = new SalesRecord(new DateTime(2020, 10, 24), 4000.0, SalesStatus.Faturado, s4);
            SalesRecord r23 = new SalesRecord(new DateTime(2020, 10, 19), 11000.0, SalesStatus.Cancelado, s2);
            SalesRecord r24 = new SalesRecord(new DateTime(2020, 10, 12), 8000.0, SalesStatus.Faturado, s5);
            SalesRecord r25 = new SalesRecord(new DateTime(2020, 10, 31), 7000.0, SalesStatus.Faturado, s3);
            SalesRecord r26 = new SalesRecord(new DateTime(2020, 10, 6), 5000.0, SalesStatus.Faturado, s4);
            SalesRecord r27 = new SalesRecord(new DateTime(2020, 10, 13), 9000.0, SalesStatus.Pendente, s1);
            SalesRecord r28 = new SalesRecord(new DateTime(2020, 10, 7), 4000.0, SalesStatus.Faturado, s3);
            SalesRecord r29 = new SalesRecord(new DateTime(2020, 10, 23), 12000.0, SalesStatus.Faturado, s5);
            SalesRecord r30 = new SalesRecord(new DateTime(2020, 10, 12), 5000.0, SalesStatus.Faturado, s2);

            _context.Departament.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
                );

            try
            {
                _context.SaveChanges();
            } catch(Exception ex)
            {
                string a = ex.ToString();
            }
            
        }
    }
} 