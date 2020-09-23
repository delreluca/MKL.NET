﻿using System;
using System.Security;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace MKLNET
{
    [SuppressUnmanagedCodeSecurity]
    public unsafe static class Vsl
    {
#if LINUX
        const string DLL = "libmkl_rt.so";
#elif OSX
        const string DLL = "libmkl_rt.dylib";
#else
        const string DLL = "mkl_rt.dll";
#endif

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngCauchy(VslMethodCauchy method, VslStream stream, int n, double[] r, double a, double beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngCauchy(VslMethodCauchy method, VslStream stream, int n, double[] r, double a, double beta)
            => vdRngCauchy(method, stream, n, r, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngCauchy(VslMethodCauchy method, VslStream stream, int n, float[] r, float a, float beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngCauchy(VslMethodCauchy method, VslStream stream, int n, float[] r, float a, float beta)
            => vsRngCauchy(method, stream, n, r, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngUniform(VslMethodUniform method, VslStream stream, int n, double[] r, double a, double b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngUniform(VslMethodUniform method, VslStream stream, int n, double[] r, double a, double b)
            => vdRngUniform(method, stream, n, r, a, b);
        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngUniform(VslMethodUniform method, VslStream stream, int n, float[] r, float a, float b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngUniform(VslMethodUniform method, VslStream stream, int n, float[] r, float a, float b)
            => vsRngUniform(method, stream, n, r, a, b);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngGaussian(VslMethodGaussian method, VslStream stream, int n, double[] r, double mean, double sigma);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngGaussian(VslMethodGaussian method, VslStream stream, int n, double[] r, double mean, double sigma)
            => vdRngGaussian(method, stream, n, r, mean, sigma);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngGaussian(VslMethodGaussian method, VslStream stream, int n, float[] r, float mean, float sigma);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngGaussian(VslMethodGaussian method, VslStream stream, int n, float[] r, float mean, float sigma)
            => vsRngGaussian(method, stream, n, r, mean, sigma);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngGaussianMV(VslMethodGaussian method, VslStream stream, int n, double[] r, int dimen, int mstorage, double[] a, double[] t);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngGaussianMV(VslMethodGaussian method, VslStream stream, int n, double[] r, int dimen, int mstorage, double[] a, double[] t)
            => vdRngGaussianMV(method, stream, n, r, dimen, mstorage, a, t);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngGaussianMV(VslMethodGaussian method, VslStream stream, int n, float[] r, int dimen, int mstorage, float[] a, float[] t);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngGaussianMV(VslMethodGaussian method, VslStream stream, int n, float[] r, int dimen, int mstorage, float[] a, float[] t)
            => vsRngGaussianMV(method, stream, n, r, dimen, mstorage, a, t);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngExponential(VslMethodExponential method, VslStream stream, int n, double[] r, double a, double beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngExponential(VslMethodExponential method, VslStream stream, int n, double[] r, double a, double beta)
            => vdRngExponential(method, stream, n, r, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngExponential(VslMethodExponential method, VslStream stream, int n, float[] r, float a, float beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngExponential(VslMethodExponential method, VslStream stream, int n, float[] r, float a, float beta)
            => vsRngExponential(method, stream, n, r, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngLaplace(VslMethodLaplace method, VslStream stream, int n, double[] r, double a, double beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngLaplace(VslMethodLaplace method, VslStream stream, int n, double[] r, double a, double beta)
            => vdRngLaplace(method, stream, n, r, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngLaplace(VslMethodLaplace method, VslStream stream, int n, float[] r, float a, float beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngLaplace(VslMethodLaplace method, VslStream stream, int n, float[] r, float a, float beta)
            => vsRngLaplace(method, stream, n, r, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngWeibull(VslMethodWeibull method, VslStream stream, int n, double[] r, double alpha, double a, double beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngWeibull(VslMethodWeibull method, VslStream stream, int n, double[] r, double alpha, double a, double beta)
            => vdRngWeibull(method, stream, n, r, alpha, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngWeibull(VslMethodWeibull method, VslStream stream, int n, float[] r, float alpha, float a, float beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngWeibull(VslMethodWeibull method, VslStream stream, int n, float[] r, float alpha, float a, float beta)
            => vsRngWeibull(method, stream, n, r, alpha, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngRayleigh(VslMethodRayleigh method, VslStream stream, int n, double[] r, double a, double beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngRayleigh(VslMethodRayleigh method, VslStream stream, int n, double[] r, double a, double beta)
            => vdRngRayleigh(method, stream, n, r, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngRayleigh(VslMethodRayleigh method, VslStream stream, int n, float[] r, float a, float beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngRayleigh(VslMethodRayleigh method, VslStream stream, int n, float[] r, float a, float beta)
            => vsRngRayleigh(method, stream, n, r, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngLognormal(VslMethodLognormal method, VslStream stream, int n, double[] r, double a, double sigma, double b, double beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngLognormal(VslMethodLognormal method, VslStream stream, int n, double[] r, double a, double sigma, double b, double beta)
            => vdRngLognormal(method, stream, n, r, a, sigma, b, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngLognormal(VslMethodLognormal method, VslStream stream, int n, float[] r, float a, float sigma, float b, float beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngLognormal(VslMethodLognormal method, VslStream stream, int n, float[] r, float a, float sigma, float b, float beta)
            => vsRngLognormal(method, stream, n, r, a, sigma, b, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngGumbel(VslMethodGumbel method, VslStream stream, int n, double[] r, double a, double beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngGumbel(VslMethodGumbel method, VslStream stream, int n, double[] r, double a, double beta)
            => vdRngGumbel(method, stream, n, r, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngGumbel(VslMethodGumbel method, VslStream stream, int n, float[] r, float a, float beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngGumbel(VslMethodGumbel method, VslStream stream, int n, float[] r, float a, float beta)
            => vsRngGumbel(method, stream, n, r, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngGamma(VslMethodGamma method, VslStream stream, int n, double[] r, double alpha, double a, double beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngGamma(VslMethodGamma method, VslStream stream, int n, double[] r, double alpha, double a, double beta)
            => vdRngGamma(method, stream, n, r, alpha, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngGamma(VslMethodGamma method, VslStream stream, int n, float[] r, float alpha, float a, float beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngGamma(VslMethodGamma method, VslStream stream, int n, float[] r, float alpha, float a, float beta)
            => vsRngGamma(method, stream, n, r, alpha, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngBeta(VslMethodBeta method, VslStream stream, int n, double[] r, double p, double q, double a, double beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngBeta(VslMethodBeta method, VslStream stream, int n, double[] r, double p, double q, double a, double beta)
            => vdRngBeta(method, stream, n, r, p, q, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngBeta(VslMethodBeta method, VslStream stream, int n, float[] r, float p, float q, float a, float beta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngBeta(VslMethodBeta method, VslStream stream, int n, float[] r, float p, float q, float a, float beta)
            => vsRngBeta(method, stream, n, r, p, q, a, beta);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vdRngChiSquare(VslMethodChiSquare method, VslStream stream, int n, double[] r, int v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngChiSquare(VslMethodChiSquare method, VslStream stream, int n, double[] r, int v)
            => vdRngChiSquare(method, stream, n, r, v);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsRngChiSquare(VslMethodChiSquare method, VslStream stream, int n, float[] r, int v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngChiSquare(VslMethodChiSquare method, VslStream stream, int n, float[] r, int v)
            => vsRngChiSquare(method, stream, n, r, v);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngBernoulli(VslMethodBernoulli method, VslStream stream, int n, int[] r, double p);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngBernoulli(VslMethodBernoulli method, VslStream stream, int n, int[] r, double p)
            => viRngBernoulli(method, stream, n, r, p);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngUniform(VslMethodUniform method, VslStream stream, int n, int[] r, int a, int b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngUniform(VslMethodUniform method, VslStream stream, int n, int[] r, int a, int b)
            => viRngUniform(method, stream, n, r, a, b);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngUniformBits(VslMethodUniformBits method, VslStream stream, int n, uint[] r);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngUniformBits(VslMethodUniformBits method, VslStream stream, int n, uint[] r)
            => viRngUniformBits(method, stream, n, r);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngUniformBits32(VslMethodUniformBits method, VslStream stream, int n, uint[] r);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngUniformBits32(VslMethodUniformBits method, VslStream stream, int n, uint[] r)
            => viRngUniformBits32(method, stream, n, r);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngUniformBits64(VslMethodUniformBits method, VslStream stream, int n, ulong[] r);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngUniformBits64(VslMethodUniformBits method, VslStream stream, int n, ulong[] r)
            => viRngUniformBits64(method, stream, n, r);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngGeometric(VslMethodGeometric method, VslStream stream, int n, int[] r, double p);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngGeometric(VslMethodGeometric method, VslStream stream, int n, int[] r, double p)
            => viRngGeometric(method, stream, n, r, p);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngBinomial(VslMethodBinomial method, VslStream stream, int n, int[] r, int ntrial, double p);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngBinomial(VslMethodBinomial method, VslStream stream, int n, int[] r, int ntrial, double p)
            => viRngBinomial(method, stream, n, r, ntrial, p);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngMultinomial(VslMethodMultinomial method, VslStream stream, int n, int[] r, int ntrial, int k, double[] p);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngMultinomial(VslMethodMultinomial method, VslStream stream, int n, int[] r, int ntrial, int k, double[] p)
            => viRngMultinomial(method, stream, n, r, ntrial, k, p);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngHypergeometric(VslMethodHypergeometric method, VslStream stream, int n, int[] r, int l, int s, int m);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngHypergeometric(VslMethodHypergeometric method, VslStream stream, int n, int[] r, int l, int s, int m)
            => viRngHypergeometric(method, stream, n, r, l, s, m);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngNegBinomial(VslMethodNegBinomial method, VslStream stream, int n, int[] r, double a, double p);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngNegBinomial(VslMethodNegBinomial method, VslStream stream, int n, int[] r, double a, double p)
            => viRngNegBinomial(method, stream, n, r, a, p);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngPoisson(VslMethodPoisson method, VslStream stream, int n, int[] r, double lambda);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngPoisson(VslMethodPoisson method, VslStream stream, int n, int[] r, double lambda)
            => viRngPoisson(method, stream, n, r, lambda);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int viRngPoissonV(VslMethodPoissonV method, VslStream stream, int n, int[] r, double[] lambda);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RngPoissonV(VslMethodPoissonV method, VslStream stream, int n, int[] r, double[] lambda)
            => viRngPoissonV(method, stream, n, r, lambda);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslNewStream(out VslStream stream, VslBrng brng, uint seed);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int NewStream(out VslStream stream, VslBrng brng, uint seed)
            => vslNewStream(out stream, brng, seed);
        public static VslStream NewStream(VslBrng brng, uint seed)
        {
            int status = NewStream(out var stream, brng, seed);
            if (status != 0) throw new Exception("Non zero status: " + status);
            return stream;
        }

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslNewStreamEx(out VslStream stream, VslBrng brng, uint seed, uint[] param);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int NewStreamEx(out VslStream stream, VslBrng brng, uint seed, uint[] param)
            => vslNewStreamEx(out stream, brng, seed, param);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslDeleteStream(ref VslStream stream);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int DeleteStream(VslStream stream)
            => vslDeleteStream(ref stream);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCopyStream(out VslStream newstream, VslStream srcstream);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CopyStream(out VslStream newstream, VslStream srcstream)
            => vslCopyStream(out newstream, srcstream);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCopyStreamState(out VslStream deststream, VslStream srcstream);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CopyStreamState(out VslStream deststream, VslStream srcstream)
            => vslCopyStreamState(out deststream, srcstream);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslLeapfrogStream(VslStream stream, int k, int nstreams);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int LeapfrogStream(VslStream stream, int k, int nstreams)
            => vslLeapfrogStream(stream, k, nstreams);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslSkipAheadStream(VslStream stream, int nskip);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SkipAheadStream(VslStream stream, int nskip)
            => vslSkipAheadStream(stream, nskip);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslSkipAheadStreamEx(VslStream stream, int n, ulong[] nskip);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SkipAheadStreamEx(VslStream stream, int n, ulong[] nskip)
            => vslSkipAheadStreamEx(stream, n, nskip);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslGetStreamStateBrng(VslStream stream);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetStreamStateBrng(VslStream stream)
            => vslGetStreamStateBrng(stream);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldConvNewTask(out VsldConvTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvNewTask(out VsldConvTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape)
            => vsldConvNewTask(out task, mode, dims, xshape, yshape, zshape);
        
        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsConvNewTask(out VslsConvTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvNewTask(out VslsConvTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape)
            => vslsConvNewTask(out task, mode, dims, xshape, yshape, zshape);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldCorrNewTask(out VsldCorrTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrNewTask(out VsldCorrTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape)
            => vsldCorrNewTask(out task, mode, dims, xshape, yshape, zshape);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsCorrNewTask(out VslsCorrTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrNewTask(out VslsCorrTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape)
            => vslsCorrNewTask(out task, mode, dims, xshape, yshape, zshape);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldConvNewTask1D(out VsldConvTask task, VslMode mode, int xshape, int yshape, int zshape);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvNewTask1D(out VsldConvTask task, VslMode mode, int xshape, int yshape, int zshape)
            => vsldConvNewTask1D(out task, mode, xshape, yshape, zshape);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsConvNewTask1D(out VslsConvTask task, VslMode mode, int xshape, int yshape, int zshape);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvNewTask1D(out VslsConvTask task, VslMode mode, int xshape, int yshape, int zshape)
            => vslsConvNewTask1D(out task, mode, xshape, yshape, zshape);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldCorrNewTask1D(out VsldCorrTask task, VslMode mode, int xshape, int yshape, int zshape);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrNewTask1D(out VsldCorrTask task, VslMode mode, int xshape, int yshape, int zshape)
            => vsldCorrNewTask1D(out task, mode, xshape, yshape, zshape);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsCorrNewTask1D(out VslsCorrTask task, VslMode mode, int xshape, int yshape, int zshape);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrNewTask1D(out VslsCorrTask task, VslMode mode, int xshape, int yshape, int zshape)
            => vslsCorrNewTask1D(out task, mode, xshape, yshape, zshape);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldConvNewTaskX(out VsldConvTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape, double[] x, int[] xstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvNewTaskX(out VsldConvTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape, double[] x, int[] xstride)
            => vsldConvNewTaskX(out task, mode, dims, xshape, yshape, zshape, x, xstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsConvNewTaskX(out VslsConvTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape, float[] x, int[] xstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvNewTaskX(out VslsConvTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape, float[] x, int[] xstride)
            => vslsConvNewTaskX(out task, mode, dims, xshape, yshape, zshape, x, xstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldCorrNewTaskX(out VsldCorrTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape, double[] x, int[] xstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrNewTaskX(out VsldCorrTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape, double[] x, int[] xstride)
            => vsldCorrNewTaskX(out task, mode, dims, xshape, yshape, zshape, x, xstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsCorrNewTaskX(out VslsCorrTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape, float[] x, int[] xstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrNewTaskX(out VslsCorrTask task, VslMode mode, int dims, int[] xshape, int[] yshape, int[] zshape, float[] x, int[] xstride)
            => vslsCorrNewTaskX(out task, mode, dims, xshape, yshape, zshape, x, xstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldConvNewTaskX1D(out VsldConvTask task, VslMode mode, int xshape, int yshape, int zshape, double[] x, int xstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvNewTaskX1D(out VsldConvTask task, VslMode mode, int xshape, int yshape, int zshape, double[] x, int xstride)
            => vsldConvNewTaskX1D(out task, mode, xshape, yshape, zshape, x, xstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsConvNewTaskX1D(out VslsConvTask task, VslMode mode, int xshape, int yshape, int zshape, float[] x, int xstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvNewTaskX1D(out VslsConvTask task, VslMode mode, int xshape, int yshape, int zshape, float[] x, int xstride)
            => vslsConvNewTaskX1D(out task, mode, xshape, yshape, zshape, x, xstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldCorrNewTaskX1D(out VsldCorrTask task, VslMode mode, int xshape, int yshape, int zshape, double[] x, int xstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrNewTaskX1D(out VsldCorrTask task, VslMode mode, int xshape, int yshape, int zshape, double[] x, int xstride)
            => vsldCorrNewTaskX1D(out task, mode, xshape, yshape, zshape, x, xstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsCorrNewTaskX1D(out VslsCorrTask task, VslMode mode, int xshape, int yshape, int zshape, float[] x, int xstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrNewTaskX1D(out VslsCorrTask task, VslMode mode, int xshape, int yshape, int zshape, float[] x, int xstride)
            => vslsCorrNewTaskX1D(out task, mode, xshape, yshape, zshape, x, xstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvDeleteTask(ref VsldConvTask task);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvDeleteTask(VsldConvTask task)
            => vslConvDeleteTask(ref task);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvDeleteTask(ref VslsConvTask task);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvDeleteTask(VslsConvTask task)
            => vslConvDeleteTask(ref task);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrDeleteTask(ref VsldCorrTask task);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrDeleteTask(VsldCorrTask task)
            => vslCorrDeleteTask(ref task);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrDeleteTask(ref VslsCorrTask task);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrDeleteTask(VslsCorrTask task)
            => vslCorrDeleteTask(ref task);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvCopyTask(out VsldConvTask newtask, VsldConvTask srctask);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvCopyTask(out VsldConvTask newtask, VsldConvTask srctask)
            => vslConvCopyTask(out newtask, srctask);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvCopyTask(out VslsConvTask newtask, VslsConvTask srctask);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvCopyTask(out VslsConvTask newtask, VslsConvTask srctask)
            => vslConvCopyTask(out newtask, srctask);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrCopyTask(out VsldCorrTask newtask, VsldCorrTask srctask);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrCopyTask(out VsldCorrTask newtask, VsldCorrTask srctask)
            => vslCorrCopyTask(out newtask, srctask);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrCopyTask(out VslsCorrTask newtask, VslsCorrTask srctask);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrCopyTask(out VslsCorrTask newtask, VslsCorrTask srctask)
            => vslCorrCopyTask(out newtask, srctask);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvSetMode(VsldConvTask task, VslMode newmode);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvSetMode(VsldConvTask task, VslMode newmode)
            => vslConvSetMode(task, newmode);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvSetMode(VslsConvTask task, VslMode newmode);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvSetMode(VslsConvTask task, VslMode newmode)
            => vslConvSetMode(task, newmode);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrSetMode(VsldCorrTask task, VslMode newmode);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrSetMode(VsldCorrTask task, VslMode newmode)
            => vslCorrSetMode(task, newmode);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrSetMode(VslsCorrTask task, VslMode newmode);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrSetMode(VslsCorrTask task, VslMode newmode)
            => vslCorrSetMode(task, newmode);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvSetInternalPrecision(VsldConvTask task, VslPrecision precision);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvSetInternalPrecision(VsldConvTask task, VslPrecision precision)
            => vslConvSetInternalPrecision(task, precision);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvSetInternalPrecision(VslsConvTask task, VslPrecision precision);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvSetInternalPrecision(VslsConvTask task, VslPrecision precision)
            => vslConvSetInternalPrecision(task, precision);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrSetInternalPrecision(VsldCorrTask task, VslPrecision precision);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrSetInternalPrecision(VsldCorrTask task, VslPrecision precision)
            => vslCorrSetInternalPrecision(task, precision);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrSetInternalPrecision(VslsCorrTask task, VslPrecision precision);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrSetInternalPrecision(VslsCorrTask task, VslPrecision precision)
            => vslCorrSetInternalPrecision(task, precision);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvSetStart(VsldConvTask task, int[] start);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvSetStart(VsldConvTask task, int[] start)
            => vslConvSetStart(task, start);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvSetStart(VslsConvTask task, int[] start);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvSetStart(VslsConvTask task, int[] start)
            => vslConvSetStart(task, start);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrSetStart(VsldCorrTask task, int[] start);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrSetStart(VsldCorrTask task, int[] start)
            => vslCorrSetStart(task, start);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrSetStart(VslsCorrTask task, int[] start);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrSetStart(VslsCorrTask task, int[] start)
            => vslCorrSetStart(task, start);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvSetDecimation(VsldConvTask task, int[] decimation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvSetDecimation(VsldConvTask task, int[] decimation)
            => vslConvSetDecimation(task, decimation);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslConvSetDecimation(VslsConvTask task, int[] decimation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvSetDecimation(VslsConvTask task, int[] decimation)
            => vslConvSetDecimation(task, decimation);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrSetDecimation(VsldCorrTask task, int[] decimation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrSetDecimation(VsldCorrTask task, int[] decimation)
            => vslCorrSetDecimation(task, decimation);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslCorrSetDecimation(VslsCorrTask task, int[] decimation);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrSetDecimation(VslsCorrTask task, int[] decimation)
            => vslCorrSetDecimation(task, decimation);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldConvExec(VsldConvTask task, double[] x, int[] xstride, double[] y, int[] ystride, double[] z, int[] zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvExec(VsldConvTask task, double[] x, int[] xstride, double[] y, int[] ystride, double[] z, int[] zstride)
            => vsldConvExec(task, x, xstride, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsConvExec(VslsConvTask task, float[] x, int[] xstride, float[] y, int[] ystride, float[] z, int[] zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvExec(VslsConvTask task, float[] x, int[] xstride, float[] y, int[] ystride, float[] z, int[] zstride)
            => vslsConvExec(task, x, xstride, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldCorrExec(VsldCorrTask task, double[] x, int[] xstride, double[] y, int[] ystride, double[] z, int[] zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrExec(VsldCorrTask task, double[] x, int[] xstride, double[] y, int[] ystride, double[] z, int[] zstride)
            => vsldCorrExec(task, x, xstride, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsCorrExec(VslsCorrTask task, float[] x, int[] xstride, float[] y, int[] ystride, float[] z, int[] zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrExec(VslsCorrTask task, float[] x, int[] xstride, float[] y, int[] ystride, float[] z, int[] zstride)
            => vslsCorrExec(task, x, xstride, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldConvExec1D(VsldConvTask task, double[] x, int xstride, double[] y, int ystride, double[] z, int zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvExec1D(VsldConvTask task, double[] x, int xstride, double[] y, int ystride, double[] z, int zstride)
            => vsldConvExec1D(task, x, xstride, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsConvExec1D(VslsConvTask task, float[] x, int xstride, float[] y, int ystride, float[] z, int zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvExec1D(VslsConvTask task, float[] x, int xstride, float[] y, int ystride, float[] z, int zstride)
            => vslsConvExec1D(task, x, xstride, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldCorrExec1D(VsldCorrTask task, double[] x, int xstride, double[] y, int ystride, double[] z, int zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrExec1D(VsldCorrTask task, double[] x, int xstride, double[] y, int ystride, double[] z, int zstride)
            => vsldCorrExec1D(task, x, xstride, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsCorrExec1D(VslsCorrTask task, float[] x, int xstride, float[] y, int ystride, float[] z, int zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrExec1D(VslsCorrTask task, float[] x, int xstride, float[] y, int ystride, float[] z, int zstride)
            => vslsCorrExec1D(task, x, xstride, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldConvExecX(VsldConvTask task, double[] y, int[] ystride, double[] z, int[] zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvExecX(VsldConvTask task, double[] y, int[] ystride, double[] z, int[] zstride)
            => vsldConvExecX(task, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsConvExecX(VslsConvTask task, float[] y, int[] ystride, float[] z, int[] zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvExecX(VslsConvTask task, float[] y, int[] ystride, float[] z, int[] zstride)
            => vslsConvExecX(task, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldCorrExecX(VsldCorrTask task, double[] y, int[] ystride, double[] z, int[] zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrExecX(VsldCorrTask task, double[] y, int[] ystride, double[] z, int[] zstride)
            => vsldCorrExecX(task, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsCorrExecX(VslsCorrTask task, float[] y, int[] ystride, float[] z, int[] zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrExecX(VslsCorrTask task, float[] y, int[] ystride, float[] z, int[] zstride)
            => vslsCorrExecX(task, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldConvExecX1D(VsldConvTask task, double[] y, int ystride, double[] z, int zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvExecX1D(VsldConvTask task, double[] y, int ystride, double[] z, int zstride)
            => vsldConvExecX1D(task, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsConvExecX1D(VslsConvTask task, float[] y, int ystride, float[] z, int zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConvExecX1D(VslsConvTask task, float[] y, int ystride, float[] z, int zstride)
            => vslsConvExecX1D(task, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldCorrExecX1D(VsldCorrTask task, double[] y, int ystride, double[] z, int zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrExecX1D(VsldCorrTask task, double[] y, int ystride, double[] z, int zstride)
            => vsldCorrExecX1D(task, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsCorrExecX1D(VslsCorrTask task, float[] y, int ystride, float[] z, int zstride);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CorrExecX1D(VslsCorrTask task, float[] y, int ystride, float[] z, int zstride)
            => vslsCorrExecX1D(task, y, ystride, z, zstride);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSNewTask(IntPtr* task, IntPtr p, IntPtr n, IntPtr xstorage, IntPtr x, IntPtr w, IntPtr indices);
        public static VsldSSTask SSNewTask(int p, int n, VslStorage storage, double[] x)
        {
            var pp = Marshal.AllocHGlobal(sizeof(int) * 3);
            Marshal.WriteInt32(pp, p);
            var np = IntPtr.Add(pp, sizeof(int));
            Marshal.WriteInt32(np, n);
            var sp = IntPtr.Add(np, sizeof(int));
            Marshal.WriteInt32(sp, (int)storage);
            var xp = GCHandle.Alloc(x, GCHandleType.Pinned);
            IntPtr task;
            var status = vsldSSNewTask(&task, pp, np, sp, xp.AddrOfPinnedObject(), IntPtr.Zero, IntPtr.Zero);
            if (status != 0) throw new Exception("Non zero status: " + status);
            return new VsldSSTask { Ptr = task, Allocated = pp, X = xp };
        }
        public static VsldSSTask SSNewTask(int p, int n, VslStorage storage, double[] x, double[] w)
        {
            var pp = Marshal.AllocHGlobal(sizeof(int) * 3);
            Marshal.WriteInt32(pp, p);
            var np = IntPtr.Add(pp, sizeof(int));
            Marshal.WriteInt32(np, n);
            var sp = IntPtr.Add(np, sizeof(int));
            Marshal.WriteInt32(sp, (int)storage);
            var xp = GCHandle.Alloc(x, GCHandleType.Pinned);
            var wp = GCHandle.Alloc(w, GCHandleType.Pinned);
            IntPtr task;
            var status = vsldSSNewTask(&task, pp, np, sp, xp.AddrOfPinnedObject(), wp.AddrOfPinnedObject(), IntPtr.Zero);
            if (status != 0) throw new Exception("Non zero status: " + status);
            return new VsldSSTask { Ptr = task, Allocated = pp, X = xp, W = wp };
        }

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSNewTask(out VslsSSTask task, int p, int n, VslStorage xstorage, float[] x, float[] w, int[] indices);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSNewTask(out VslsSSTask task, int p, int n, VslStorage xstorage, float[] x, float[] w, int[] indices)
            => vslsSSNewTask(out task, p, n, xstorage, x, w, indices);
        public static VslsSSTask SSNewTask(int p, int n, VslStorage xstorage, float[] x, float[] w, int[] indices)
        {
            var status = vslsSSNewTask(out var task, p, n, xstorage, x, w, indices);
            if (status != 0) throw new Exception("Non zero status: " + status);
            return task;
        }

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditTask(IntPtr task, VslEdit parameter, IntPtr value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditTask(VsldSSTask task, VslEdit parameter, double[] value)
        {
            var p = GCHandle.Alloc(value, GCHandleType.Pinned);
            task.Mean = p;
            return vsldSSEditTask(task.Ptr, parameter, p.AddrOfPinnedObject());
        }

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditTask(VslsSSTask task, VslEdit parameter, float[] value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditTask(VslsSSTask task, VslEdit parameter, float[] value)
            => vslsSSEditTask(task, parameter, value);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsliSSEditTask(VsliSSTask task, VslEdit parameter, int[] value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditTask(VsliSSTask task, VslEdit parameter, int[] value)
            => vsliSSEditTask(task, parameter, value);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditMoments(VsldSSTask task, double[] mean, double[] r2m, double[] r3m, double[] r4m, double[] c2m, double[] c3m, double[] c4m);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditMoments(VsldSSTask task, double[] mean, double[] r2m, double[] r3m, double[] r4m, double[] c2m, double[] c3m, double[] c4m)
            => vsldSSEditMoments(task, mean, r2m, r3m, r4m, c2m, c3m, c4m);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditMoments(VslsSSTask task, float[] mean, float[] r2m, float[] r3m, float[] r4m, float[] c2m, float[] c3m, float[] c4m);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditMoments(VslsSSTask task, float[] mean, float[] r2m, float[] r3m, float[] r4m, float[] c2m, float[] c3m, float[] c4m)
            => vslsSSEditMoments(task, mean, r2m, r3m, r4m, c2m, c3m, c4m);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditSums(VsldSSTask task, double[] sum, double[] r2s, double[] r3s, double[] r4s, double[] c2s, double[] c3s, double[] c4s);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditSums(VsldSSTask task, double[] sum, double[] r2s, double[] r3s, double[] r4s, double[] c2s, double[] c3s, double[] c4s)
            => vsldSSEditSums(task, sum, r2s, r3s, r4s, c2s, c3s, c4s);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditSums(VslsSSTask task, float[] sum, float[] r2s, float[] r3s, float[] r4s, float[] c2s, float[] c3s, float[] c4s);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditSums(VslsSSTask task, float[] sum, float[] r2s, float[] r3s, float[] r4s, float[] c2s, float[] c3s, float[] c4s)
            => vslsSSEditSums(task, sum, r2s, r3s, r4s, c2s, c3s, c4s);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditCovCor(VsldSSTask task, double[] mean, double[] cov, VslFormat cov_storage, double[] cor, VslFormat cor_storage);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditCovCor(VsldSSTask task, double[] mean, double[] cov, VslFormat cov_storage, double[] cor, VslFormat cor_storage)
            => vsldSSEditCovCor(task, mean, cov, cov_storage, cor, cor_storage);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditCovCor(VslsSSTask task, float[] mean, float[] cov, VslFormat cov_storage, float[] cor, VslFormat cor_storage);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditCovCor(VslsSSTask task, float[] mean, float[] cov, VslFormat cov_storage, float[] cor, VslFormat cor_storage)
            => vslsSSEditCovCor(task, mean, cov, cov_storage, cor, cor_storage);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditCP(VsldSSTask task, double[] mean, double[] sum, double[] cp, VslFormat cp_storage);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditCP(VsldSSTask task, double[] mean, double[] sum, double[] cp, VslFormat cp_storage)
            => vsldSSEditCP(task, mean, sum, cp, cp_storage);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditCP(VslsSSTask task, float[] mean, float[] sum, float[] cp, VslFormat cp_storage);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditCP(VslsSSTask task, float[] mean, float[] sum, float[] cp, VslFormat cp_storage)
            => vslsSSEditCP(task, mean, sum, cp, cp_storage);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditPartialCovCor(VsldSSTask task, int[] p_idx_array, double[] cov, VslStorage cov_storage, double[] cor, VslStorage cor_storage, double[] p_cov, VslStorage p_cov_storage, double[] p_cor, VslStorage p_cor_storage);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditPartialCovCor(VsldSSTask task, int[] p_idx_array, double[] cov, VslStorage cov_storage, double[] cor, VslStorage cor_storage, double[] p_cov, VslStorage p_cov_storage, double[] p_cor, VslStorage p_cor_storage)
            => vsldSSEditPartialCovCor(task, p_idx_array, cov, cov_storage, cor, cor_storage, p_cov, p_cov_storage, p_cor, p_cor_storage);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditPartialCovCor(VslsSSTask task, int[] p_idx_array, float[] cov, VslStorage cov_storage, float[] cor, VslStorage cor_storage, float[] p_cov, VslStorage p_cov_storage, float[] p_cor, VslStorage p_cor_storage);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditPartialCovCor(VslsSSTask task, int[] p_idx_array, float[] cov, VslStorage cov_storage, float[] cor, VslStorage cor_storage, float[] p_cov, VslStorage p_cov_storage, float[] p_cor, VslStorage p_cor_storage)
            => vslsSSEditPartialCovCor(task, p_idx_array, cov, cov_storage, cor, cor_storage, p_cov, p_cov_storage, p_cor, p_cor_storage);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditQuantiles(VsldSSTask task, int quant_order_n, double[] quant_order, double[] quants, double[] order_stats, VslStorage order_stats_storage);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditQuantiles(VsldSSTask task, int quant_order_n, double[] quant_order, double[] quants, double[] order_stats, VslStorage order_stats_storage)
            => vsldSSEditQuantiles(task, quant_order_n, quant_order, quants, order_stats, order_stats_storage);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditQuantiles(VslsSSTask task, int quant_order_n, float[] quant_order, float[] quants, float[] order_stats, VslStorage order_stats_storage);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditQuantiles(VslsSSTask task, int quant_order_n, float[] quant_order, float[] quants, float[] order_stats, VslStorage order_stats_storage)
            => vslsSSEditQuantiles(task, quant_order_n, quant_order, quants, order_stats, order_stats_storage);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditStreamQuantiles(VsldSSTask task, int quant_order_n, double[] quant_order, double[] quants, int nparams, double[] vparams);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditStreamQuantiles(VsldSSTask task, int quant_order_n, double[] quant_order, double[] quants, int nparams, double[] vparams)
            => vsldSSEditStreamQuantiles(task, quant_order_n, quant_order, quants, nparams, vparams);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditStreamQuantiles(VslsSSTask task, int quant_order_n, float[] quant_order, float[] quants, int nparams, float[] vparams);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditStreamQuantiles(VslsSSTask task, int quant_order_n, float[] quant_order, float[] quants, int nparams, float[] vparams)
            => vslsSSEditStreamQuantiles(task, quant_order_n, quant_order, quants, nparams, vparams);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditPooledCovariance(VsldSSTask task, int[] grp_indices, double[] pld_mean, double[] pld_cov, int[] req_grp_indices, double[] grp_means, double[] grp_cov);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditPooledCovariance(VsldSSTask task, int[] grp_indices, double[] pld_mean, double[] pld_cov, int[] req_grp_indices, double[] grp_means, double[] grp_cov)
            => vsldSSEditPooledCovariance(task, grp_indices, pld_mean, pld_cov, req_grp_indices, grp_means, grp_cov);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditPooledCovariance(VslsSSTask task, int[] grp_indices, float[] pld_mean, float[] pld_cov, int[] req_grp_indices, float[] grp_means, float[] grp_cov);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditPooledCovariance(VslsSSTask task, int[] grp_indices, float[] pld_mean, float[] pld_cov, int[] req_grp_indices, float[] grp_means, float[] grp_cov)
            => vslsSSEditPooledCovariance(task, grp_indices, pld_mean, pld_cov, req_grp_indices, grp_means, grp_cov);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditRobustCovariance(VsldSSTask task, VslStorage rcov_storage, int nparams, double[] vparams, double[] rmean, double[] rcov);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditRobustCovariance(VsldSSTask task, VslStorage rcov_storage, int nparams, double[] vparams, double[] rmean, double[] rcov)
            => vsldSSEditRobustCovariance(task, rcov_storage, nparams, vparams, rmean, rcov);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditRobustCovariance(VslsSSTask task, VslStorage rcov_storage, int nparams, float[] vparams, float[] rmean, float[] rcov);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditRobustCovariance(VslsSSTask task, VslStorage rcov_storage, int nparams, float[] vparams, float[] rmean, float[] rcov)
            => vslsSSEditRobustCovariance(task, rcov_storage, nparams, vparams, rmean, rcov);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditOutliersDetection(VsldSSTask task, int nparams, double[] vparams, double[] w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditOutliersDetection(VsldSSTask task, int nparams, double[] vparams, double[] w)
            => vsldSSEditOutliersDetection(task, nparams, vparams, w);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditOutliersDetection(VslsSSTask task, int nparams, float[] vparams, float[] w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditOutliersDetection(VslsSSTask task, int nparams, float[] vparams, float[] w)
            => vslsSSEditOutliersDetection(task, nparams, vparams, w);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditMissingValues(VsldSSTask task, int nparams, double[] vparams, int init_estimates_n, double[] init_estimates, int prior_n, double[] prior, int simul_missing_vals_n, double[] simul_missing_vals, int estimates_n, double[] estimates);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditMissingValues(VsldSSTask task, int nparams, double[] vparams, int init_estimates_n, double[] init_estimates, int prior_n, double[] prior, int simul_missing_vals_n, double[] simul_missing_vals, int estimates_n, double[] estimates)
            => vsldSSEditMissingValues(task, nparams, vparams, init_estimates_n, init_estimates, prior_n, prior, simul_missing_vals_n, simul_missing_vals, estimates_n, estimates);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditMissingValues(VslsSSTask task, int nparams, float[] vparams, int init_estimates_n, float[] init_estimates, int prior_n, float[] prior, int simul_missing_vals_n, float[] simul_missing_vals, int estimates_n, float[] estimates);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditMissingValues(VslsSSTask task, int nparams, float[] vparams, int init_estimates_n, float[] init_estimates, int prior_n, float[] prior, int simul_missing_vals_n, float[] simul_missing_vals, int estimates_n, float[] estimates)
            => vslsSSEditMissingValues(task, nparams, vparams, init_estimates_n, init_estimates, prior_n, prior, simul_missing_vals_n, simul_missing_vals, estimates_n, estimates);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSEditCorParameterization(VsldSSTask task, double[] cor, VslStorage cor_storage, double[] pcor, VslStorage pcor_storage);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditCorParameterization(VsldSSTask task, double[] cor, VslStorage cor_storage, double[] pcor, VslStorage pcor_storage)
            => vsldSSEditCorParameterization(task, cor, cor_storage, pcor, pcor_storage);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSEditCorParameterization(VslsSSTask task, float[] cor, VslStorage cor_storage, float[] pcor, VslStorage pcor_storage);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSEditCorParameterization(VslsSSTask task, float[] cor, VslStorage cor_storage, float[] pcor, VslStorage pcor_storage)
            => vslsSSEditCorParameterization(task, cor, cor_storage, pcor, pcor_storage);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vsldSSCompute(IntPtr task, VslEstimate estimates, VslMethod method);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSCompute(VsldSSTask task, VslEstimate estimates, VslMethod method)
        {
            return vsldSSCompute(task.Ptr, estimates, method);
        }

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslsSSCompute(VslsSSTask task, VslEstimate estimates, VslMethod method);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSCompute(VslsSSTask task, VslEstimate estimates, VslMethod method)
            => vslsSSCompute(task, estimates, method);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslSSDeleteTask(IntPtr* task);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSDeleteTask(VsldSSTask task)
        {
            Marshal.FreeHGlobal(task.Allocated);
            task.X.Free();
            task.Mean.Free();
            if (task.W.IsAllocated) task.W.Free();
            var t = task.Ptr;
            return vslSSDeleteTask(&t);
        }

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslSSDeleteTask(ref VslsSSTask task);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSDeleteTask(VslsSSTask task)
            => vslSSDeleteTask(ref task);

        [DllImport(DLL, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        static extern int vslSSDeleteTask(ref VsliSSTask task);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SSDeleteTask(VsliSSTask task)
            => vslSSDeleteTask(ref task);
    }
}